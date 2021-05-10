import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { logout, receiveSession } from "../../Actions/SessionActions";
import { AppState } from "../../store";
import { decodeUser, refreshAccessToken, setupTokenRefresh } from "../../Util/SessionUtil";

export const AuthManager: React.FC = ({ children }) => {

    // Setups middleware which automatically refreshes tokens when needed.
    // It dispatches logout() when a token refresh is failed.
    setupTokenRefresh(() => dispatch(logout()));

    const restoringSession = useSelector((s: AppState) => s.session.restoringSession);
    const dispatch = useDispatch();

    if (restoringSession) {
        try {
            const act = async () => {
                const jwt = await refreshAccessToken();
                const user = decodeUser(jwt);
                dispatch(receiveSession(user));
            };
            act();
        } catch (error) {
            dispatch(logout());
            throw error;
        }
    }

    return <>{restoringSession ? <h1>LOADING</h1> : children}</>;
};
