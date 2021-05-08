import { Store, createStore, combineReducers, applyMiddleware } from "redux";
import thunk from "redux-thunk";
import logger from "redux-logger";
import { sessionReducer } from "./Reducers/SessionReducer";
import { usersReducer } from "./Reducers/UsersReducer";

const rootReducer = combineReducers({
    session: sessionReducer,
    users: usersReducer
});

// Automatically infer type from reducer's return type.
export type AppState = ReturnType<typeof rootReducer>

export const configureStore = (): Store<AppState> => {
    const store = createStore(rootReducer, applyMiddleware(thunk, logger));
    return store;
};