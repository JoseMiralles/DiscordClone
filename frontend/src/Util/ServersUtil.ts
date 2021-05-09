import axios, { AxiosResponse } from "axios";
import { ICreateServerDTO, IServer } from "../Models/ServerModel";
import { IMultipleUserResponseItem } from "../Models/UserModel";

export const fetchUserServersUtil = async (): Promise<IServer[]> => {
    const req = await axios.get("/api/server");
    return req.data;
};

export const postNewServerUtil = async (
    newServer: ICreateServerDTO
): Promise<IServer> => {
    const req = await axios.post("/api/server", newServer);
    console.log(axios);
    return req.data
};

export const fetchServerUsersUtil = async (
    serverId: number
): Promise<IMultipleUserResponseItem[]> => {
    const req = await axios.get(`/api/Server/Users/${serverId}`);
    return req.data;
};

export const fetchServerByIdUtil = async (
    serverId: number
): Promise<IMultipleUserResponseItem> => {
    const req = await axios.get(`/api/server/${serverId}`);
    return req.data;
};