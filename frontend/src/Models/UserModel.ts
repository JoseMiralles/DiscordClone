
// Users
export interface IUser {
    readonly userName: string;
    readonly id: string;
}

export interface IUserState {
    readonly users: IUser[];
}
