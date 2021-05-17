import { Dispatch } from "react";
import { IMessage, IMessagePostDTO } from "../Models/MessagesModel";
import { AppActions } from "../store";
import { deleteMessageUtil, fetchChannelMessagesUtil, postMessageUtil } from "../Util/MessagesUtil";


export const fetchingMessages = (): AppActions => ({
    type: "FETCHING_MESSAGES"
});

export const receiveAllMessages = (messages: IMessage[]): AppActions => ({
    type: "RECEIVE_ALL_MESSAGES",
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

export const getChannelMessages = async (channelId: number) => async (
    dispatch: Dispatch<AppActions>
) => {
    dispatch(fetchingMessages());
    try {
        const messages = await fetchChannelMessagesUtil(channelId);
        dispatch(receiveAllMessages(messages.map(m => ({
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