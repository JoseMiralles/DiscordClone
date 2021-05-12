import { AnyAction, Dispatch } from "redux";

export interface IMiddleware<S, E extends AnyAction> {
    dispatch: Dispatch<E>,
    getState(): S
}

export type Middleware<S, E extends AnyAction> =
    (api: IMiddleware<S, E>) =>
        (next: Dispatch<E>) =>
            (event: E) => ReturnType<Dispatch<E>>;
