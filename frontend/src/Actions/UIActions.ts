import { AppActions } from "../store";

export const setUserVarVisibility = (visible: boolean): AppActions => ({
    type: "SET_USER_BAR_VISIBILITY",
    visible
});