import { Store, createStore, combineReducers, applyMiddleware } from "redux";
import thunk from "redux-thunk";
import logger from "redux-logger";
import { sessionReducer } from "./Reducers/SessionReducer";
import { usersReducer } from "./Reducers/UsersReducer";
import modalReducer from "./Reducers/ModalReducer";
import serverReducer from "./Reducers/ServersReducer";

const rootReducer = combineReducers({
    session: sessionReducer,
    users: usersReducer,
    servers: serverReducer,
    modal: modalReducer,
});

// Automatically infer type from reducer's return type.
export type AppState = ReturnType<typeof rootReducer>

export const configureStore = (): Store<AppState> => {
    const store = createStore(rootReducer, applyMiddleware(thunk, logger));
    return store;
};