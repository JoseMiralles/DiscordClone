import { AppActions } from "../Models/AppModel";
import { IUser } from "../Models/UserModel";

export const receiveServerUsers = (users: IUser[]): AppActions => ({
    type: "RECEIVE_SERVER_USERS",
    users
});

export const receiveUser = (user: IUser): AppActions => ({
    type: "RECEIVE_USER",
    user
});
