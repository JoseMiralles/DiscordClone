import axios, { AxiosResponse } from "axios";
import { IAuthResponseDTO, ILoginDTO, ISessionState } from "../Models/SessionModel";

export const utilLogin = async (loginDTO: ILoginDTO): Promise<ISessionState> => {
    return await axios.post(
        "https://localhost:5001/api/AuthManagment/Login",
        loginDTO
    ).then((res: AxiosResponse<IAuthResponseDTO>) => {
        updateAxiosJWT(res.data.token);
        return {
            userId: "awfwef",
            loading: false
        };
    });
};

export const utilRefreshToken = async (): Promise<ISessionState> => { };

/**
 * Sets up interceptor for all axios responses and requests new tokens when needed automatically.
 * It then updates the new tokens locally, and attempts to perform the original request with an updated "Authorization" header.
 */
export const setupAxiosTokenRefresh = () => {
    axios.interceptors.response.use(response => {
        return response; // Initial request was successful, return response.
    }, async (error) => {
        // Request failed, attempt to refresh tokens if that was the issue.
        
    });
};

/**
 * Updates jwt token for all new requets.
 * @param token The new jwt.
 */
function updateAxiosJWT(token: string) {
    axios.interceptors.request.use(config => {
        config.headers["Authorization"] = "Bearer " + token;
        return config;
    });
}
