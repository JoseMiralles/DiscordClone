import { Dispatch } from "redux";
import { AppActions } from "../Models/AppModel";
import { ILoginDTO, IRegisterDTO, ISessionErrors, ISessionState } from "../Models/SessionModel";
import { AppState } from "../store";
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

export const login = async (loginDTO: ILoginDTO) =>
    async (dispatch: Dispatch<AppActions>, getState: () => AppState) => {
        dispatch(gettingSession());
        try {
            const res = await utilLogin(loginDTO)
            dispatch(receiveSession(getUserId(res.data.token)));
        } catch (error) {
            dispatch(receiveSessionErrors(
                error.response.data.errors
            ));
        }
    };

export const register = async (registerDTO: IRegisterDTO) =>
    async (dispatch: Dispatch<AppActions>, getState: () => AppState) => {
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

export const clearSessionErrors = () =>
    (dispatch: Dispatch<AppActions>, getState: () => AppState) => {
        dispatch(receiveSessionErrors({
            Email: [],
            Password: [],
            Username: []
        }));
    };

export const logout = () =>
    (dispatch: Dispatch<AppActions>, getState: () => AppState) => {
        utilLogout();
        dispatch(removeSession());
    }

export const tokensRefreshed = (sessionState: ISessionState) =>
    (dispatch: Dispatch<AppActions>, getState: () => AppState) => {
        dispatch(receiveSession(sessionState.userId));
    };