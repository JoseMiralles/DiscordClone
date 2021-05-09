import { Dispatch } from "redux";
import { AppActions } from "../Models/AppModel";
import { ICreateServerDTO, IServer } from "../Models/ServerModel";
import { IMultipleUserResponseItem } from "../Models/UserModel";
import { fetchServerByIdUtil, fetchServerUsersUtil, fetchUserServersUtil, postNewServerUtil } from "../Util/ServersUtil";

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

export const selectServer = (serverId: number): AppActions => ({
    type: "SELECT_SERVER",
    serverId
});

export const receiveServerUsers = (
    users: IMultipleUserResponseItem[],
    serverId: number
): AppActions => ({
    type: "RECEIVE_SERVER_USERS",
    users,
    serverId
});

export const createServer = (newServer: ICreateServerDTO) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingServers());
    try {
        const server = await postNewServerUtil(newServer);
        dispatch(receiveServer(server));
        dispatch(selectServer(server.id));
    } catch (error) {
        // TODO: handle errors
        console.log(error);
    }
};

export const fetchUserServers = () => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingServers());
    try {
        const servers: IServer[] = await fetchUserServersUtil();
        dispatch(receiveAllServers(servers));
    } catch (error) {
        console.log(error);
    }
};

export const fetchServerUsers = (serverId: number) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingServers());
    try {
        const users = await fetchServerUsersUtil(serverId);
        dispatch(receiveServerUsers(users, serverId));
    } catch (error) {
        console.log(error);
    };
};