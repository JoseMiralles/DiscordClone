
export interface ISetUserBarVisibility {
    type: "SET_USER_BAR_VISIBILITY";
    visible: boolean;
}

export interface ISetChannelBarVisibility {
    type: "SET_CHANNEL_BAR_VISIBILITY";
    visible: boolean;
}

export type UIActionTypes =
    ISetUserBarVisibility |
    ISetChannelBarVisibility;

export interface IUIState {
    userBarVisibility: boolean;
    channelBarVisibility: boolean;
}