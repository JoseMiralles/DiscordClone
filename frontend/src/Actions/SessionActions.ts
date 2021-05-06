import { Dispatch } from "react";
import { AppActions } from "../Models/AppModel";
import { ILoginDTO, IRegisterDTO, ISessionErrors, ISessionState } from "../Models/SessionModel";
import { utilLogin, utilLogout, utilRegister, getUserId } from "../Util/SessionUtil";

// When a login or register form is submitted (show loading anim).
export const gettingSession = (): AppActions => ({
    type: "GETTING_SESSION"
} as const);

// When the response of the auth request comes back.
export const receiveSession = (userId: string): AppActions => ({
    type: "RECEIVE_SESSION",
    userId
} as const);

// When the user logs out.
export const removeSession = () => ({
    type: "REMOVE_SESSION"
} as const);

export const receiveSessionErrors = (errors: ISessionErrors) => ({
    type: "RECEIVE_SESSION_ERRORS",
    errors
} as const);

export type SessionActions =
    | ReturnType<typeof gettingSession>
    | ReturnType<typeof receiveSession>
    | ReturnType<typeof removeSession>
    | ReturnType<typeof receiveSessionErrors>;

export const login = async (loginDTO: ILoginDTO) =>
    async (dispatch: Dispatch<SessionActions>) => {
        dispatch(gettingSession());
        try {
            const res = await utilLogin(loginDTO)
            dispatch(receiveSession(getUserId(res.data.token)));
        } catch (error) {
            dispatch(receiveSessionErrors(
                error.response.data.errors
            ));
        }
            // .then((res: ISessionState) => dispatch(receiveSession(res)))
            // .catch(error => {
            //     console.log(error);
            // });
    };

export const register = async (registerDTO: IRegisterDTO) =>
    async (dispatch: Dispatch<SessionActions>) => {
        dispatch(gettingSession());
        try {
            const res = await utilRegister(registerDTO);
            dispatch(receiveSession(
                getUserId(res.data.token)
            ));
        } catch (error) {
            dispatch(receiveSessionErrors(
                error.response.data.errors
            ));
        }
    };

export const clearSessionErrors = () => (dispatch: Dispatch<SessionActions>) => {
    dispatch(receiveSessionErrors({
        Email: [],
        Password: [],
        Username: []
    }));
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