import { AppActions } from "../store";

export const setUserVarVisibility = (visible: boolean): AppActions => ({
    type: "SET_USER_BAR_VISIBILITY",
    visible
});

export const setChannelBarVisibility = (visible: boolean): AppActions => ({
    type: "SET_CHANNEL_BAR_VISIBILITY",
    visible
});

export const closeAllBars = (): AppActions => ({
    type: "CLOSE_ALL_BARS"
});