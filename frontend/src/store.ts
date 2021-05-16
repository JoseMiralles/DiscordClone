import { Store, createStore, combineReducers, applyMiddleware } from "redux";
import thunk, { ThunkMiddleware } from "redux-thunk";
import logger from "redux-logger";
import { sessionReducer } from "./Reducers/SessionReducer";
import { usersReducer } from "./Reducers/UsersReducer";
import modalReducer from "./Reducers/ModalReducer";
import serverReducer from "./Reducers/ServersReducer";
import { SessionActionTypes } from "./Models/SessionModel";
import { UserActionTypes } from "./Models/UserModel";
import { ModalActionTypes } from "./Models/ModalModel";
import { serverActionTypes } from "./Models/ServerModel";
import SignalRMiddleware from "./Middleware/SignalRMiddleware";
import { isDev } from "./Util/EnviromentUtil";
import { textChannelActionTypes } from "./Models/TextChannelModel";
import textChannelsReducer from "./Reducers/TextChannelsReducer";

// This will be a union type of all potential action types.
export type AppActions =
    SessionActionTypes |
    UserActionTypes |
    ModalActionTypes |
    serverActionTypes |
    textChannelActionTypes;

const rootReducer = combineReducers({
    session: sessionReducer,
    users: usersReducer,
    servers: serverReducer,
    textChannels: textChannelsReducer,
    modal: modalReducer,
});

// Automatically infer type from reducer's return type.
export type AppState = ReturnType<typeof rootReducer>

export const configureStore = (): Store<AppState> => {

    const middleware = isDev() ? [logger, SignalRMiddleware] : [SignalRMiddleware];

    const store = createStore(rootReducer, applyMiddleware(
        thunk as ThunkMiddleware<AppState, AppActions>,
        ...middleware
    ));
    return store;
};