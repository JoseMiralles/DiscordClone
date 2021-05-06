import { Dispatch } from "react";
import { ILoginDTO, IRegisterDTO, ISessionErrors, ISessionState } from "../Models/SessionModel";
import { utilLogin, utilLogout, utilRegister, getUserId } from "../Util/SessionUtil";

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

export const RECEIVE_SESSION_ERRORS = "RECEIVE_SESSION_ERRORS";
export const receiveSessionErrors = (errors: ISessionErrors) => ({
    type: RECEIVE_SESSION_ERRORS,
    errors
});

export type SessionActions =
    | ReturnType<typeof gettingSession>
    | ReturnType<typeof receiveSession>
    | ReturnType<typeof removeSession>
    | ReturnType<typeof receiveSessionErrors>;

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
        try {
            const res = await utilRegister(registerDTO);
            dispatch(receiveSession({
                userId: getUserId(res.data.token),
                loading: false,
                restoringSession: false
            }));
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