import { Store, createStore, combineReducers } from "redux";
import { ISessionState } from "./Models/SessionModel";
import { sessionReducer } from "./Reducers/SessionReducer";

export interface IAppSate {
    readonly session: ISessionState;
    // readonly servers: IServerState;
    // readonly users: IUserState;
}

const rootReducer = combineReducers<IAppSate>({
    session: sessionReducer
});

export const configureStore = (): Store<IAppSate> => {
    const store = createStore(rootReducer, undefined);
    return store;
};