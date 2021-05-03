import React from "react";
import { useDispatch } from "react-redux";
import { logout, tokensRefreshed } from "../../Actions/SessionActions";
import { ISessionState } from "../../Models/SessionModel";
import { refreshAccessToken, setupAxiosTokenRefresh } from "../../Util/SessionUtil";

export const AuthManager: React.FC = ({children}) => {
    const dispatch = useDispatch();

    // Attempt to restore previous session if refresh token exists.
    if (localStorage.getItem("RT")) {
        refreshAccessToken(
            (data) => dispatch(tokensRefreshed(data))
        ).then(async () => {
            await setupAxiosTokenRefresh(
                "",
                (sessionState: ISessionState) => dispatch(tokensRefreshed(sessionState)),
                () => dispatch(logout())
            );
        }
        );
    }

    return <>{children}</>;
};
