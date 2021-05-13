import { serverRole } from "./ServerModel";

export const RECEIVE_USER = "RECEIVE_USER";
export const RECEIVE_ALL_ONLINE_USERS = "RECEIVE_ALL_ONLINE_USERS";
export const RECEIVE_USER_STATUS = "RECEIVE_USER_STATUS";

export interface IreceiveUser {
    type: "RECEIVE_USER";
    user: IUser
}

export interface IreceiveAllOnlineUsers {
    type: "RECEIVE_ALL_ONLINE_USERS";
    userIds: string[];
}

export interface IReceiveUserStatus {
    type: "RECEIVE_USER_STATUS";
    userId: string;
    isOnline: boolean;
}

export interface IMultipleUserResponseItem {
    userId: string,
    userName: string,
    role: serverRole
}

export type UserActionTypes =
    IreceiveUser |
    IreceiveAllOnlineUsers |
    IReceiveUserStatus;


export interface IUser {
    readonly userName: string;
    readonly id: string;
    readonly online?: boolean;
}

export interface IUserState {
    readonly users: {[Identifier: string]: IUser};
}
