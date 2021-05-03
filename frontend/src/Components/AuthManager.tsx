import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { login, logout, tokensRefreshed } from "../Actions/SessionActions";
import { ISessionState } from "../Models/SessionModel";
import { IAppSate } from "../store";
import { refreshAccessToken, setupAxiosTokenRefresh } from "../Util/SessionUtil";

interface Props {
    children: JSX.Element
};

export const AuthManager = (props: Props) => {

    var userId = useSelector((state: IAppSate) => state.session.userId);
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

    useEffect(() => {
        // Attempt to refresh token if one is present.
    });

    return props.children;
};
