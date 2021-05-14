import { HubConnection, HubConnectionBuilder, HubConnectionState } from "@microsoft/signalr";
import { Console } from "console";
import { receiveAllOnlineUsers, reveiceUserStatus } from "../Actions/UserActions";
import { AppActions, AppState } from "../store";
import { baseAPIUrl } from "../Util/EnviromentUtil";
import { isTokenExpired, refreshAccessToken } from "../Util/SessionUtil";
import { Middleware } from "./MiddlewareModel";

/**
 * A piece of middleware that listens to actions to initialize and to
 * interface with a remote SignalR hub.
 * @returns A curried function with an instance of SignalRHub.
 */
const SignalRMiddleware: Middleware<AppState, AppActions> = (store) => {

    let token = "";
    let prevServer: number | null = null;

    let connection: HubConnection = new HubConnectionBuilder()
        .withUrl(baseAPIUrl + "/hubs/intalk",
            { accessTokenFactory: () => isTokenExpired(token) ? refreshAccessToken() : token })
        .withAutomaticReconnect()
        .build();

    connection?.on("ReceiveAllOnlineUsers", (userIds: string[]) => {
        store.dispatch(receiveAllOnlineUsers(userIds));
    });

    connection?.on("ReveiceUserStatus", (userId: string, isOnline: boolean) => {
        store.dispatch(reveiceUserStatus(userId, isOnline));
    });

    return (next) => (action) => {

        switch (action.type) {

            case "RECEIVE_SESSION": {
                token = action.token;
                if (connection.state === HubConnectionState.Disconnected) {
                    connection.start().then(() => {
                        const selectedServerId = store.getState().servers.selected;
                        if (selectedServerId) {
                            prevServer
                                ? connection?.send("RejoinServer", selectedServerId)
                                : connection?.send("RejoinServer", selectedServerId, prevServer);
                        }
                    }).catch((reason: any) => {
                        // TODO: handle error.
                        throw reason;
                    });
                }
                break;
            }

            case "REMOVE_SESSION": {
                connection.stop();
                token = "";
                break;
            }

            case "RECEIVE_REFRESHED_TOKEN": {
                token = action.token;
                break;
            }

            case "SELECT_SERVER": {
                prevServer = store.getState().servers.selected;
                break;
            }
                
            case "RECEIVE_SERVER_USERS": {
                try {
                    if (connection.state === HubConnectionState.Connected) {
                        if (prevServer){
                            connection?.send("JoinServer", action.serverId, prevServer)
                        } else {
                            connection?.send("JoinServer", action.serverId);
                        }
                    }
                } catch (error) {
                    throw error;
                }
            }
        }

        return next(action);
    };
};

export default SignalRMiddleware;