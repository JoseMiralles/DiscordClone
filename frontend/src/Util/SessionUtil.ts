import axios from "axios";
import { ILoginDTO, ISessionState } from "../Models/SessionModel";

export const utilLogin = async (loginDTO: ILoginDTO): Promise<ISessionState> => {
    return await axios.post(
        "https://localhost:5001/api/AuthManagment/Login",
        loginDTO
    ).then(res => {
        return {
            userId: "awfwef",
            jwt: "123123",
            loading: false
        };
    });
};
