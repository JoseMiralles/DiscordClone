import { IUser } from "../Models/UserModel";
import { AppActions } from "../store";

export const receiveUser = (user: IUser): AppActions => ({
    type: "RECEIVE_USER",
    user
});

export const receiveAllOnlineUsers = (userIds: string[]): AppActions => ({
    type: "RECEIVE_ALL_ONLINE_USERS",
    userIds
});

export const reveiceUserStatus = (userId: string, isOnline: boolean): AppActions => ({
    type: "RECEIVE_USER_STATUS",
    userId,
    isOnline
});
