import axios, { AxiosResponse } from "axios";
import { ICreateServerDTO, IServer } from "../Models/ServerModel";

export const fetchUserServersUtil = async (): Promise<IServer[]> => {
    const req = await axios.get("/api/server");
    return req.data;
};

export const postNewServerUtil = async (
    newServer: ICreateServerDTO
): Promise<IServer> => {
    const req = await axios.post("/api/server", newServer);
    debugger
    console.log(axios);
    return req.data
};
