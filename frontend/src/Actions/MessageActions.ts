import { Dispatch } from "react";
import { IMessage, IMessagePostDTO } from "../Models/MessagesModel";
import { AppActions } from "../store";
import { deleteMessageUtil, fetchChannelMessagesUtil, postMessageUtil } from "../Util/MessagesUtil";


export const fetchingMessages = (): AppActions => ({
    type: "FETCHING_MESSAGES"
});

export const receiveFirstMessages = (messages: IMessage[]): AppActions => ({
    type: "RECEIVE_FIRST_MESSAGES",
    messages
});

export const receiveMoreMessages = (messages: IMessage[]): AppActions => ({
    type: "RECEIVE_MORE_MESSAGES",
    messages
});

export const receiveOneMessage = (message: IMessage): AppActions => ({
    type: "RECEIVE_ONE_MESSAGE",
    message
});

export const removeMessage = (id: number): AppActions => ({
    type: "REMOVE_MESSAGE",
    id
});

export const getChannelFirstMessages = async (channelId: number) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingMessages());
    try {
        const messages = await fetchChannelMessagesUtil(channelId);
        dispatch(receiveFirstMessages(messages.map(m => ({
            ...m,
            created: new Date(m.created)
        }))));
    } catch (error) {
        throw error;
    }
};

export const getMoreChannelMessages = async (
    channelId: number, offset: number
) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingMessages());
    try {
        const messages = await fetchChannelMessagesUtil(channelId, offset);
        dispatch(receiveMoreMessages(messages.map(m => ({
            ...m,
            created: new Date(m.created)
        }))));
    } catch (error) {
        throw error;
    }
};

export const createMessage = async (messageDTO: IMessagePostDTO) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingMessages());
    try {
        const message = await postMessageUtil(messageDTO);
        dispatch(receiveOneMessage({
            ...message,
            created: new Date(message.created)
        }));
    } catch (error) {
        throw error;
    }
};

export const deleteMessage = async (messageId: number) => async(
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingMessages());
    try {
        const deletedMId = (await deleteMessageUtil(messageId)).id;
        dispatch(removeMessage(deletedMId));
    } catch (error) {
        throw error;
    }
};