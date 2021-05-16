import { Dispatch } from "react";
import { ITextChannel } from "../Models/TextChannelModel";
import { AppActions } from "../store";
import { fetchServerTextChannelsUtil } from "../Util/TextChannelsUtil";

export const fetchingTextChannels = (): AppActions => ({
    type: "FETCHING_TEXT_CHANNELS"
});

export const receiveServerTextChannels = (channels: ITextChannel[]): AppActions => ({
    type: "RECEIVER_SERVER_TEXT_CHANNELS",
    channels
});

export const selectTextChannel = (textChannelId: number): AppActions => ({
    type: "SELECT_TEXT_CHANNEL",
    textChannelId
});

export const getTextChannels = (serverId: number) => async (dispatch: Dispatch<AppActions>) => {
    dispatch(fetchingTextChannels());
    try {
        const channels = await fetchServerTextChannelsUtil(serverId);
        dispatch(receiveServerTextChannels(channels));
    } catch (error) {
        throw error;
    }
};