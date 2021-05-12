import { logout, removeSession } from "../Actions/SessionActions";
import { AppActions, AppState } from "../store";
import { Middleware } from "./MiddlewareModel";

const SignalRMiddleware: Middleware<AppState, AppActions> = (store) => (next) => (action) => {
    
    switch (action.type) {
        case "RECEIVE_SESSION": {
            // TODO: Connect and notify users. 
            break;
        }
    }

    return next(action);
};

export default SignalRMiddleware;