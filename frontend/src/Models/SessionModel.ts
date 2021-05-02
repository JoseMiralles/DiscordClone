
export interface ISessionState {
    readonly userId: string | null;
    readonly jwt: string | null;
    readonly loading: boolean;
}