import axios, { AxiosResponse } from "axios";
import { IAuthResponseDTO, ILoginDTO, IRefreshTokenRequest, ISessionState } from "../Models/SessionModel";

export const utilLogin = async (loginDTO: ILoginDTO): Promise<ISessionState> => {
    return await axios.post(
        "/api/AuthManagment/Login",
        loginDTO
    ).then((res: AxiosResponse<IAuthResponseDTO>) => {
        updateAxiosBearer(res.data.token);
        localStorage.setItem("RT", res.data.refreshToken);
        localStorage.setItem("T", res.data.token);
        return {
            userId: getUserId(res.data.token),
            loading: false
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
                        loading: false
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
    async (onSuccess?: (data: ISessionState) => void): Promise<IAuthResponseDTO | null> => {
        if (
            localStorage.getItem("RT")
            && localStorage.getItem("RT") !== "null"
            && localStorage.getItem("T")
            && localStorage.getItem("T") !== "null"
        ) {
            const rtr: IRefreshTokenRequest = {
                token: localStorage.getItem("T") || "",
                refreshToken: localStorage.getItem("RT") || ""
            };
            const res = await axios.post(
                "/api/AuthManagment/RefreshToken",
                rtr
            );
            localStorage.setItem("RT", res.data.refreshToken);
            localStorage.setItem("T", res.data.token);
            if (onSuccess) onSuccess({
                userId: getUserId(res.data.token),
                loading: false
            });
            return res.data;
        }
        return null;
    };

export const utilLogout = () => {
    localStorage.removeItem("RT");
    localStorage.removeItem("T");
}

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
