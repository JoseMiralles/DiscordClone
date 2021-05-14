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
        let connection: HubConnection = new HubConnectionBuilder()
            .withUrl(baseAPIUrl + "/hubs/intalk",
                { accessTokenFactory: () => isTokenExpired(token) ? refreshAccessToken() : token })
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
                        connection.start().catch((reason: any) => {
                            // TODO: handle error.
                            throw reason;
                        });
                    }
                    break;
                }

                case "REMOVE_SESSION": {
                    // TODO: Close connection.
                    token = "";
                    break;
                }

                case "RECEIVE_REFRESHED_TOKEN": {
                    token = action.token;
                    break;
                }
                    
                case "SELECT_SERVER": {
                    const prevServer = store.getState().servers.selected;
                    console.log(prevServer);
                    try {
                        prevServer ?
                        connection?.send("SelectServer", action.serverId, prevServer) :
                        connection?.send("SelectServer", action.serverId);
                    } catch (error) {
                        console.log(error);
                    }
                }
            }

            return next(action);
        };
    };

export default SignalRMiddleware;