import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { logout, tokensRefreshed } from "../../Actions/SessionActions";
import { ISessionState } from "../../Models/SessionModel";
import { IAppSate } from "../../store";
import { refreshAccessToken, setupAxiosTokenRefresh } from "../../Util/SessionUtil";

export const AuthManager: React.FC = ({children}) => {
    const dispatch = useDispatch();
    const { restoringSession } = useSelector((s: IAppSate) => s.session);

    // Attempt to restore previous session if refresh token exists.
    if (localStorage.getItem("RT") && restoringSession) {
        refreshAccessToken(
            (data) => dispatch(tokensRefreshed(data)),
            (reason) => {
                console.log(reason);
                dispatch(logout());
            }
        ).then(async () => {
            await setupAxiosTokenRefresh(
                "",
                (sessionState: ISessionState) => dispatch(tokensRefreshed(sessionState)),
                () => dispatch(logout())
            );
        }
        );
    } else if (restoringSession) {
        dispatch(logout());
    }

    return <>{children}</>;
};
