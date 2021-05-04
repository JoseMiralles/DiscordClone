import axios, { AxiosResponse } from "axios";
import { Console } from "node:console";
import { IAuthResponseDTO, ILoginDTO, IRefreshTokenRequest, IRegisterDTO, ISessionState } from "../Models/SessionModel";

export const utilLogin = async (loginDTO: ILoginDTO): Promise<ISessionState> => {
    return await axios.post(
        "/api/AuthManagment/Login",
        loginDTO
    ).then((res: AxiosResponse<IAuthResponseDTO>) => {
        updateAxiosBearer(res.data.token);
        persistTokens({
            jwt: res.data.token,
            refreshToken: res.data.token
        });
        return {
            userId: getUserId(res.data.token),
            loading: false,
            restoringSession: false
        };
    });
};

export const utilRegister = async (registerDTO: IRegisterDTO): Promise<ISessionState> => {
    return await axios.post(
        "api/AuthManagment/register",
        registerDTO
    ).then((res: AxiosResponse<IAuthResponseDTO>) => {
        updateAxiosBearer(res.data.token);
        persistTokens({
            jwt: res.data.token,
            refreshToken: res.data.token
        });
        return {
            userId: getUserId(res.data.token),
            loading: false,
            restoringSession: false
        };
    });
};

/**
 * Sets up interceptor for all axios responses and requests new tokens when needed automatically.
 * It then updates the new tokens locally, and attempts to perform the original request with an updated "Authorization" header.
 */
export const setupAxiosTokenRefresh =
    async (
        oldJwt: string,
        successfulRefresh: (sesStt: ISessionState) => void,
        failedRefresh: () => void
        // TODO: Might have to also take "gettingSession" dispatch.
    ) => {
        axios.interceptors.response.use(response => {
            return response; // Initial request was successful, return response.
        }, async (error) => {
            // Request failed, attempt to refresh tokens if that was the issue.
            // Call successfulRefresh if the tokens were refreshed.
            const originalRequest = error.config;
            if (error.response.status === 403 && !originalRequest._retry) {
                originalRequest._retry = true;
                const authResponse: IAuthResponseDTO | null = await refreshAccessToken();

                if (authResponse) {
                    // Refresh successfull, dispatch refreshToken action.
                    updateAxiosBearer(authResponse.token);
                    successfulRefresh({
                        userId: getUserId(authResponse.token),
                        loading: false,
                        restoringSession: false
                    });
                    return axios(originalRequest);
                } else {
                    // Unsuccsesful, dispatch logout action.
                    failedRefresh();
                }
            }
        });
    };

export const refreshAccessToken =
    async (onSuccess?: (data: ISessionState) => void, onFailure?: (reason: any) => void): Promise<IAuthResponseDTO | null> => {
        console.log("refreshing tokens");
        const tokenSet: ITokenSet = getTokenSet();
        if (
            tokenSet.jwt && tokenSet.refreshToken
        ) {
            console.log("tokens found");
            const rtr: IRefreshTokenRequest = {
                token: tokenSet.jwt || "",
                refreshToken: tokenSet.refreshToken || ""
            };
            await axios.post(
                "/api/AuthManagment/RefreshToken",
                rtr
            ).then((res: AxiosResponse<IAuthResponseDTO>) => {
                console.log("success");
                persistTokens({
                    jwt: res.data.token,
                    refreshToken: res.data.refreshToken
                });
                if (onSuccess) onSuccess({
                    userId: getUserId(res.data.token),
                    loading: false,
                    restoringSession: false
                });
                return res.data;
            }, (reason) => {
                console.log("failure");
                if (onFailure) onFailure(reason);
            });
        }
        console.log("tokens not found");
        return null;
    };

export const utilLogout = () => {
    localStorage.removeItem("RT");
    localStorage.removeItem("T");
}

interface ITokenSet {
    jwt: string;
    refreshToken: string;
}
const persistTokens = (set: ITokenSet) => {
    localStorage.setItem("RT", set.refreshToken);
    localStorage.setItem("T", set.jwt);
};
export const getTokenSet = (): ITokenSet => {
    return {
        jwt: localStorage.getItem("T") || "",
        refreshToken: localStorage.getItem("RT") || ""
    };
};

/**
 * Extracts userId claim from jwt.
 */
const getUserId = (jwt: string): string => {
    return "placeholderId"
};

/**
 * Updates jwt token for all new requets.
 * @param token The new jwt.
 */
function updateAxiosBearer(token: string) {
    axios.interceptors.request.use(config => {
        config.headers["Authorization"] = "Bearer " + token;
        return config;
    });
}
