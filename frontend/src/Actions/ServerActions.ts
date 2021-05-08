import { Dispatch } from "redux";
import { AppActions } from "../Models/AppModel";
import { ICreateServerDTO, IServer } from "../Models/ServerModel";
import { AppState } from "../store";
import { postNewServerUtil } from "../Util/ServersUtil";

export const fetchingServers = (): AppActions => ({
    type: "FETCHING_SERVERS"
});

export const receiveServer = (server: IServer): AppActions => ({
    type: "RECEIVE_SERVER",
    server
});

export const receiveAllServers = (servers: IServer[]): AppActions => ({
    type: "RECEIVE_ALL_SERVERS",
    servers
});

export const removeServer = (serverId: number): AppActions => ({
    type: "REMOVE_SERVER",
    serverId
});

export const createServer = (newServer: ICreateServerDTO) => async (
    dispatch: Dispatch
) => {
    dispatch(fetchingServers());
    try {
        const server = await postNewServerUtil(newServer);
        dispatch(receiveServer(server));
    } catch (error) {
        // TODO: handle errors
        console.log(error);
    }
};