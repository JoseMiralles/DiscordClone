import { IMultipleUserResponseItem } from "./UserModel";

export const FETCHING_SERVERS = "FETCHING_SERVERS";
export const RECEIVE_SERVER = "RECEIVE_SERVER";
export const RECEIVE_ALL_SERVERS = "RECEIVE_ALL_SERVERS";
export const REMOVE_SERVER = "REMOVE_SERVER";
export const RECEIVE_SERVER_USERS = "RECEIVE_SERVER_USERS";
export const SELECT_SERVER = "SELECT_SERVER";

export interface IFetchingServers {
    type: "FETCHING_SERVERS"
}

export interface IReceiveServer {
    type: "RECEIVE_SERVER",
    server: IServer
}

export interface IReceiveAllServers {
    type: "RECEIVE_ALL_SERVERS",
    servers: IServer[]
}

export interface IRemoveServer {
    type: "REMOVE_SERVER",
    serverId: number
}

export interface IReceiveServerUsers {
    type: "RECEIVE_SERVER_USERS",
    users: IMultipleUserResponseItem[],
    serverId: number
}

export interface ISelectServer {
    type: "SELECT_SERVER",
    serverId: number
}

export type serverActionTypes =
    IFetchingServers |
    IReceiveServer |
    IReceiveAllServers |
    IRemoveServer |
    IReceiveServerUsers |
    ISelectServer;


// DTOs
export interface ICreateServerDTO {
    title: string;
}


// State
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
    readonly selected: number | null;
    readonly all: {[Identifier: number]: IServer};
}
