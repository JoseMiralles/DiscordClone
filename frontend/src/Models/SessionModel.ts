
export interface ISessionState {
    readonly userId: string | null;
    readonly loading: boolean;
}

export interface ILoginDTO {
    email: string;
    password: string;
}

export interface IRegisterDTO {
    email: string;
    username: string;
    password: string;
}

export interface IAuthResponseDTO {
    readonly token: string;
    readonly refreshToken: string;
    readonly errors?: string[];
}

export interface IRefreshTokenRequest {
    readonly token: string;
    readonly refreshToken: string;
}

// public string Token { get; set; }
// public string RefreshToken { get; set; }
// public bool Success { get; set; }
// public List<string> Errors { get; set; }