import { Dispatch } from "react";
import { ILoginDTO, IRegisterDTO, ISessionState } from "../Models/SessionModel";
import { utilLogin, utilLogout, utilRegister } from "../Util/SessionUtil";

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

// When the user logs out.
export const REMOVE_SESSION = "REMOVE_SESSION";
export const removeSession = () => ({
    type: REMOVE_SESSION
} as const);

export type SessionActions =
    | ReturnType<typeof gettingSession>
    | ReturnType<typeof receiveSession>
    | ReturnType<typeof removeSession>;

export const login = async (loginDTO: ILoginDTO) =>
    async (dispatch: Dispatch<SessionActions>) => {
        dispatch(gettingSession());
        return await utilLogin(loginDTO)
            .then((res: ISessionState) => dispatch(receiveSession(res)))
            .catch(error => {
                console.log(error);
            });
    };

export const register = async (registerDTO: IRegisterDTO) =>
    async (dispatch: Dispatch<SessionActions>) => {
        dispatch(gettingSession());
        return await utilRegister(registerDTO)
            .then((res: ISessionState) => dispatch(receiveSession(res)))
            .catch(error => {
                console.log(error);
            });
    };

export const logout = () =>
    (dispatch: Dispatch<SessionActions>) => {
        utilLogout();
        dispatch(removeSession());
    }

export const tokensRefreshed = (sessionState: ISessionState) =>
    (dispatch: Dispatch<SessionActions>) => {
        dispatch(receiveSession(sessionState));
    };