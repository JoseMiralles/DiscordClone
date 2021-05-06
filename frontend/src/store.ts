import { Store, createStore, combineReducers, applyMiddleware } from "redux";
import thunk from "redux-thunk";
import logger from "redux-logger";
import { sessionReducer } from "./Reducers/SessionReducer";

const rootReducer = combineReducers({
    session: sessionReducer
});

// Automatically infer type from reducer's return type.
export type AppSate = ReturnType<typeof rootReducer>

export const configureStore = (): Store<AppSate> => {
    const store = createStore(rootReducer, applyMiddleware(thunk, logger));
    return store;
};