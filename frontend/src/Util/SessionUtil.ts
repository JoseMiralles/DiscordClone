import axios, { AxiosResponse } from "axios";
import jwtDecode from "jwt-decode";
import { IAuthResponseDTO, ILoginDTO, IRefreshTokenRequest, IRegisterDTO } from "../Models/SessionModel";
import { IUser } from "../Models/UserModel";

export const utilLogin = (loginDTO: ILoginDTO): Promise<AxiosResponse<IAuthResponseDTO>> => {
    const req = axios.post(
        "/api/AuthManagment/Login",
        loginDTO
    );
    req.then((res: AxiosResponse<IAuthResponseDTO>) => {
        console.log();
        debugger
        updateAxiosBearer(res.data.token);
        persistTokens({
            jwt: res.data.token,
            refreshToken: res.data.token
        });
    });
    return req;
};

export const utilRegister = (registerDTO: IRegisterDTO): Promise<AxiosResponse<IAuthResponseDTO>> => {
    const request = axios.post(
        "/api/AuthManagment/register",
        registerDTO
    );
    request.then((res: AxiosResponse<IAuthResponseDTO>) => {
        updateAxiosBearer(res.data.token);
        persistTokens({
            jwt: res.data.token,
            refreshToken: res.data.token
        });
    });
    return request;
};

/**
 * Sets up interceptor for all axios responses and requests new tokens when needed automatically.
 * It then updates the new tokens locally, and attempts to perform the original request with an updated "Authorization" header.
 */
export const setupAxiosTokenRefresh =
    async (
        onSuccess: (user: IUser) => void,
        onFailure: () => void
    ) => {
        axios.interceptors.response.use(response => {
            return response; // Initial request was successful, return response.
        }, async (error) => {
            // Request failed, attempt to refresh tokens if that was the issue.
            // Call onSuccess if the tokens were refreshed.
            const originalRequest = error.config;
            if (error.response?.status === 403 && !originalRequest._retry) {
                originalRequest._retry = true;
                await refreshAccessToken((user) => {
                    onSuccess(user);
                }, onFailure);
                return axios(originalRequest);
            }
        });
    };

export const refreshAccessToken = async (
    onSuccess?: (user: IUser) => void,
    onFailure?: (reason: any) => void
) => {
    const tokenSet = getTokenSet();
    if (tokenSet.jwt && tokenSet.refreshToken) {
        const rtr: IRefreshTokenRequest = {
            token: tokenSet.jwt,
            refreshToken: tokenSet.refreshToken
        };
        try {
            const res = await axios.post (
                "/api/AuthManagment/RefreshToken",
                rtr
            );
            updateAxiosBearer(res.data.token);
            persistTokens({
                jwt: res.data.token,
                refreshToken: res.data.refreshToken
            });
            const user = decodeUser(res.data.token);
            if (onSuccess) onSuccess(user);
        } catch (error) {
            if (onFailure) onFailure(error);
        }
    }
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
 * Decodes a jwt, and returns a IUser object containing relevant claims.
 * @param jwt Token from which to decode the user claims.
 */
export const decodeUser = (jwt: string): IUser => {
    const decoded: { nameid: string, username: string }
        = jwtDecode(jwt);
    return {
        userName: decoded.username,
        id: decoded.nameid
    };
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
