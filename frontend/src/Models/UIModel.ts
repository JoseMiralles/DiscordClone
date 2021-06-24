
export interface ISetUserBarVisibility {
    type: "SET_USER_BAR_VISIBILITY";
    visible: boolean;
}

export interface ISetChannelBarVisibility {
    type: "SET_CHANNEL_BAR_VISIBILITY";
    visible: boolean;
}

export interface ICloseAllBars {
    type: "CLOSE_ALL_BARS";
}

export type UIActionTypes =
    ISetUserBarVisibility |
    ISetChannelBarVisibility |
    ICloseAllBars;

export interface IUIState {
    userBarVisibility: boolean;
    channelBarVisibility: boolean;
}