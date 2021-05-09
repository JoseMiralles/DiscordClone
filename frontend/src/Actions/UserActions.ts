import { AppActions } from "../Models/AppModel";
import { IUser } from "../Models/UserModel";

export const receiveUser = (user: IUser): AppActions => ({
    type: "RECEIVE_USER",
    user
});
