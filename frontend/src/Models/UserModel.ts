import { Identifier } from "typescript";

// Users
export interface IUser {
    readonly userName: string;
    readonly id: string;
}

export interface IUserState {
    // Comparable to Dictionary<string, IUser>
    readonly users: {[Identifier: string]: IUser};
}
