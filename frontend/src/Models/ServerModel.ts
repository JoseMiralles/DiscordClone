
export enum serverRole {
    member = 0,
    owner = 1
}

export interface IUserServer{
    readonly role: serverRole;
    readonly userId: string;
}

export interface IServer {
    readonly id: number;
    readonly title: string;
    readonly usersServers: IUserServer[];
    readonly userRole: serverRole;
}

export interface IServerState {
    readonly loading: boolean;
    readonly selected: IServer;
    readonly all: IServer[];
}
