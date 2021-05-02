import { ISessionState } from "../Models/SessionModel";

// When a login or register form is submitted (show loading anim).
export const GETTING_SESSION = "GETTING_SESSION";
export const gettingSession = () => ({
    type: GETTING_SESSION
} as const);

// When the response of the auth request comes back.
export const RECEIVE_SESSION = "RECEIVE_SESSION";
export const receiveSession = (session: ISessionState) => ({
    type: RECEIVE_SESSION,
    session: session
} as const);


export const REMOVE_SESSION = "REMOVE_SESSION";
export const removeSession = () => ({
    type: REMOVE_SESSION
} as const);

export type SessionActions =
    | ReturnType<typeof gettingSession>
    | ReturnType<typeof receiveSession>
    | ReturnType<typeof removeSession>;
