import { Store, createStore, combineReducers, applyMiddleware } from "redux";
import thunk, { ThunkMiddleware } from "redux-thunk";
import logger from "redux-logger";
import { sessionReducer } from "./Reducers/SessionReducer";
import { usersReducer } from "./Reducers/UsersReducer";
import modalReducer from "./Reducers/ModalReducer";
import serverReducer from "./Reducers/ServersReducer";
import { AppActions } from "./Models/AppModel";

const rootReducer = combineReducers({
    session: sessionReducer,
    users: usersReducer,
    servers: serverReducer,
    modal: modalReducer,
});

// Automatically infer type from reducer's return type.
export type AppState = ReturnType<typeof rootReducer>

export const configureStore = (): Store<AppState> => {
    const store = createStore(rootReducer, applyMiddleware(
        thunk as ThunkMiddleware<AppState, AppActions>,
        logger
    ));
    return store;
};