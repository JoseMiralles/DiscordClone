import { IUser } from "../Models/UserModel";
import { AppActions } from "../store";

export const receiveUser = (user: IUser): AppActions => ({
    type: "RECEIVE_USER",
    user
});
