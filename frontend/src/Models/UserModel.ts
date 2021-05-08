import { Identifier } from "typescript";

export const RECEIVE_SERVER_USERS = "RECEIVE_SERVER_USERS";
export const RECEIVE_USER = "RECEIVE_USER";

export interface receiveServerUsers {
    type: "RECEIVE_SERVER_USERS";
    users: IUser[];
}

export interface receiveUser {
    type: "RECEIVE_USER";
    user: IUser
}

export type UserActionTypes =
    receiveServerUsers |
    receiveUser;


export interface IUser {
    readonly userName: string;
    readonly id: string;
}

export interface IUserState {
    readonly users: {[Identifier: string]: IUser};
}
