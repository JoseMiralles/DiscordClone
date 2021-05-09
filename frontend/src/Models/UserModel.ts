import { Identifier } from "typescript";
import { serverRole } from "./ServerModel";

export const RECEIVE_USER = "RECEIVE_USER";

export interface receiveUser {
    type: "RECEIVE_USER";
    user: IUser
}

export interface IMultipleUserResponseItem {
    userId: string,
    userName: string,
    role: serverRole
}

export type UserActionTypes =
    receiveUser;


export interface IUser {
    readonly userName: string;
    readonly id: string;
}

export interface IUserState {
    readonly users: {[Identifier: string]: IUser};
}
