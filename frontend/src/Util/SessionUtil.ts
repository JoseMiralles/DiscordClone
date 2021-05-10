import axios, { AxiosResponse } from "axios";
import jwtDecode from "jwt-decode";
import { IAuthResponseDTO, ILoginDTO, IRefreshTokenRequest, IRegisterDTO } from "../Models/SessionModel";
import { IUser } from "../Models/UserModel";

export const utilLogin = async (loginDTO: ILoginDTO): Promise<AxiosResponse<IAuthResponseDTO>> => {
    const res = await axios.post(
        "/api/AuthManagment/Login",
        loginDTO
    );
    updateTokens({token: res.data.token, refreshToken: res.data.refreshToken});
    return res;
};

export const utilRegister = async (registerDTO: IRegisterDTO): Promise<AxiosResponse<IAuthResponseDTO>> => {
    const res = await axios.post(
        "/api/AuthManagment/register",
        registerDTO
    );
    updateTokens({token: res.data.token, refreshToken: res.data.refreshToken});
    return res;
};

export const utilLogout = () => {
    localStorage.removeItem("RT");
    localStorage.removeItem("T");
}

export const refreshAccessToken = async (): Promise<IUser> => {
    const tokenSet = getTokenSet();
    if (!tokenSet.refreshToken) throw (new Error("refreshAccessToken: No refresh token found."));
    try {
        const reqDTO: IRefreshTokenRequest = {
            token: tokenSet.jwt,
            refreshToken: tokenSet.refreshToken
        };
        const res = await axios.post(
            "/api/AuthManagment/RefreshToken",
            reqDTO
        );
        updateTokens(res.data);
        return decodeUser(res.data.token);
    } catch (error) {
        utilLogout();
        throw error;
    }
};

/**
 * Called when tokens are refreshed, or the user is authenticated.
 * It updates axios middleware to include the bearer token on each request.
 * And it also sets up automatic token refreshing.
 * @param data 
 */
function updateTokens(data: { token: string, refreshToken: string }): void {
    
    persistTokens({jwt: data.token, refreshToken: data.refreshToken});

    // Update bearer token
    axios.interceptors.request.use(config => {
        config.headers["Authorization"] = "Bearer " + data.token;
        return config;
    });

    axios.interceptors.response.use(
        response => response,
        async (error) => {
            // Request was not successful.
            const originalRequest = error.config;
            if ([401, 403].includes(error.response?.status) && !originalRequest._retry)
            {
                originalRequest._retry = true;
                await refreshAccessToken();
                return axios(originalRequest);
            }
            throw error;
        }
    );
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
