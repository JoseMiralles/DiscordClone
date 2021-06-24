export const SET_USER_BAR_VISIBILITY = "SET_USER_BAR_VISIBILITY";

export interface ISetUserBarVisibility {
    type: "SET_USER_BAR_VISIBILITY";
    visible: boolean;
}

export type UIActionTypes = ISetUserBarVisibility;

export interface IUIState {
    userBarVisibility: boolean;
}