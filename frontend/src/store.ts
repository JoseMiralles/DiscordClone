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
import { MessageActionTypes } from "./Models/MessagesModel";
import MessagesReducer from "./Reducers/MessagesReducer";
import { UIActionTypes } from "./Models/UIModel";
import UIReducer from "./Reducers/UIReducer";

// This will be a union type of all potential action types.
export type AppActions =
    SessionActionTypes |
    UserActionTypes |
    ModalActionTypes |
    serverActionTypes |
    textChannelActionTypes |
    MessageActionTypes|
    UIActionTypes;

const rootReducer = combineReducers({
    session: sessionReducer,
    users: usersReducer,
    messages: MessagesReducer,
    servers: serverReducer,
    textChannels: textChannelsReducer,
    modal: modalReducer,
    ui: UIReducer
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