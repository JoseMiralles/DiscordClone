import axios from "axios";
import React, { Children, useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { login } from "../Actions/SessionActions";
import { IAppSate } from "../store";

interface Props {
    children: JSX.Element
};

export const AuthManager = (props: Props) => {

    const userId = useSelector((state: IAppSate) => state.session.userId);
    const dispatch = useDispatch();

    useEffect(() => {
        // Attempt to refresh token if one is present.
    });

    return props.children;
};
