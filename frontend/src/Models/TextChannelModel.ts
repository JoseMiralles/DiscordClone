export const FETCHING_TEXT_CHANNELS = "FETCHING_TEXT_CHANNELS";
export const RECEIVER_SERVER_TEXT_CHANNELS = "RECEIVER_SERVER_TEXT_CHANNELS";
export const SELECT_TEXT_CHANNEL = "SELECT_TEXT_CHANNEL";

export interface IFetchingTextChannels {
    type: "FETCHING_TEXT_CHANNELS"
}

export interface IReceiveServerTextChannels {
    type: "RECEIVER_SERVER_TEXT_CHANNELS",
    channels: ITextChannel[]
}

export interface ISelectTextChannel {
    type: "SELECT_TEXT_CHANNEL",
    textChannelId: number
}

export type textChannelActionTypes =
    IFetchingTextChannels |
    IReceiveServerTextChannels |
    ISelectTextChannel;


export interface ITextChannel {
    title: string;
    serverId: number;
    id: number;
}

export interface ICreateTextChannelDTO {
    title: string;
    serverId: number;
}

export interface ITextChannelState {
    loading: boolean;
    textChannels: ITextChannel[];
    selected: number | null;
}