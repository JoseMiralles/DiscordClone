import React, { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { logout, receiveRefreshedToken, receiveSession } from "../../Actions/SessionActions";
import { AppState } from "../../store";
import { decodeUser, refreshAccessToken, setupTokenRefresh } from "../../Util/SessionUtil";

export const AuthManager: React.FC = ({ children }) => {

    // Setups middleware which automatically refreshes tokens when needed.
    // It's receiveRefreshedToken() is called primarily for the SignalR middleware.
    // It dispatches logout() when a token refresh is failed.
    setupTokenRefresh(
        (token: string) => dispatch(receiveRefreshedToken(token)),
        () => dispatch(logout())
    );

    const restoringSession = useSelector((s: AppState) => s.session.restoringSession);
    const dispatch = useDispatch();

    useEffect(() => {
        if (restoringSession) {
            try {
                const act = async () => {
                    const jwt = await refreshAccessToken();
                    const user = decodeUser(jwt);
                    dispatch(receiveSession(user, jwt));
                };
                act();
            } catch (error) {
                dispatch(logout());
                throw error;
            }
        }
    }, []);

    return <>{restoringSession ? <h1>LOADING</h1> : children}</>;
};
