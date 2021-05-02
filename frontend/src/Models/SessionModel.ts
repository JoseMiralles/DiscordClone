
export interface ISessionState {
    readonly userId: string | null;
    readonly jwt: string | null;
    readonly loading: boolean;
}

export interface ILoginDTO {
    email: string;
    password: string;
}