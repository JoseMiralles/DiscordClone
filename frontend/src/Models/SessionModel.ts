
export const GETTING_SESSION = "GETTING_SESSION";
export const RECEIVE_SESSION = "RECEIVE_SESSION";
export const REMOVE_SESSION = "REMOVE_SESSION";
export const RECEIVE_SESSION_ERRORS = "RECEIVE_SESSION_ERRORS";
export const CLEAR_SESSION_ERRORS = "CLEAR_SESSION_ERRORS";

export interface gettingSession {
    type: typeof GETTING_SESSION;
}

export interface receiveSession {
    type: typeof RECEIVE_SESSION;
    userId: string;
}

export interface removeSession {
    type: typeof REMOVE_SESSION;
}

export interface receiveSessionErrors {
    type: typeof RECEIVE_SESSION_ERRORS;
    errors: ISessionErrors;
}

export interface clearSessionErrors {
    type: typeof CLEAR_SESSION_ERRORS
}

export type SessionActionTypes =
    gettingSession |
    receiveSession |
    removeSession |
    receiveSessionErrors |
    clearSessionErrors;

export interface ISessionState {
    readonly userId: string;
    readonly loading: boolean;
    readonly restoringSession: boolean;
    readonly errors?: ISessionErrors;
}

export interface ISessionErrors {
    email?: string[],
    password?: string[],
    username?: string[],
    general?: string[],
}

export interface ILoginDTO {
    email: string;
    password: string;
}

export interface IRegisterDTO {
    email: string;
    username: string;
    password: string;
}

export interface IAuthResponseDTO {
    readonly token: string;
    readonly refreshToken: string;
    readonly errors?: string[];
}

export interface IRefreshTokenRequest {
    readonly token: string;
    readonly refreshToken: string;
}