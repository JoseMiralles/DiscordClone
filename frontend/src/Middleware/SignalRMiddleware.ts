import { HubConnection, HubConnectionBuilder } from "@microsoft/signalr";
import { receiveAllOnlineUsers, reveiceUserStatus } from "../Actions/UserActions";
import { AppActions, AppState } from "../store";
import { isTokenExpired, refreshAccessToken } from "../Util/SessionUtil";
import { Middleware } from "./MiddlewareModel";

/**
 * A piece of middleware that listens to actions to initialize and to
 * interface with a remote SignalR hub.
 * @returns A curried function with an instance of SignalRHub.
 */
const SignalRMiddleware = (): Middleware<AppState, AppActions> => {
    let token = "";
    let connection: HubConnection | null = null;

    return (store) => {

        const startListeners = () => {

            connection?.on("ReceiveAllOnlineUsers", (userIds: string[]) => {
                store.dispatch(receiveAllOnlineUsers(userIds));
            });
    
            connection?.on("ReveiceUserStatus", (userId: string, isOnline: boolean) => {
                store.dispatch(reveiceUserStatus(userId, isOnline));
            });
    
        };

        /**
         * Gets the curried token, and automatically renews it if needed.
         */
        const checkAndGetToken = async (): Promise<string> => {
            return isTokenExpired(token) ? refreshAccessToken() : token;
        };

        return (next) => (action) => {
            switch (action.type) {
    
                case "RECEIVE_SESSION": {
                    token = action.token;
                    connection = new HubConnectionBuilder()
                        .withUrl("https://localhost:5001/hubs/intalk",
                            { accessTokenFactory: checkAndGetToken })
                        .build();
                    startListeners();
                    connection.start().catch((reason: any) => {
                        // TODO: handle error.
                        throw reason;
                    });
                    break;
                }
    
                case "REMOVE_SESSION": {
                    // TODO: Close connection.
                    token = "";
                    break;
                }
    
                case "RECEIVE_REFRESHED_TOKEN": {
                    // TODO: find a way to replace the token without killing the connection.
                    token = action.token;
                    break;
                }
            }
    
            return next(action);
        };
    };
}

export default SignalRMiddleware;