import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { logout, tokensRefreshed } from "../../Actions/SessionActions";
import { IUser } from "../../Models/UserModel";
import { AppState } from "../../store";
import { getTokenSet, refreshAccessToken, setupAxiosTokenRefresh } from "../../Util/SessionUtil";

export const AuthManager: React.FC = ({ children }) => {
    const dispatch = useDispatch();
    const { restoringSession } = useSelector((s: AppState) => s.session);

    // Attempt to restore previous session if refresh token exists.
    if (localStorage.getItem("RT") && restoringSession) {
        refreshAccessToken(user => {
            dispatch(tokensRefreshed(user));
            setupAxiosTokenRefresh(
                (userr: IUser) => dispatch(tokensRefreshed(userr)),
                () => dispatch(logout())
            );
        });
    } else if (restoringSession) {
        dispatch(logout());
    }

    return <>{children}</>;
};
