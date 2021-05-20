export const FETCHING_MESSAGES = "FETCHING_MESSAGES";
export const RECEIVE_FIRST_MESSAGES = "RECEIVE_FIRST_MESSAGES";
export const RECEIVE_MORE_MESSAGES = "RECEIVE_MORE_MESSAGES";
export const RECEIVE_ONE_MESSAGE = "RECEIVE_ONE_MESSAGE";
export const REMOVE_MESSAGE = "REMOVE_MESSAGE";

export interface IFetchingMessages {
    type: "FETCHING_MESSAGES"
}

export interface IReceiveFirstMessages {
    type: "RECEIVE_FIRST_MESSAGES";
    messages: IMessage[];
}

export interface IReceiveMoreMessages {
    type: "RECEIVE_MORE_MESSAGES";
    messages: IMessage[];
}

export interface IReceiveOneMessage {
    type: "RECEIVE_ONE_MESSAGE";
    message: IMessage;
}

export interface IRemoveMessage {
    type: "REMOVE_MESSAGE";
    id: number;
}


export type MessageActionTypes =
    IReceiveFirstMessages |
    IReceiveOneMessage |
    IRemoveMessage |
    IFetchingMessages |
    IReceiveMoreMessages;


export interface IMessage {
    id: number;
    userId: string;
    text: string;
    textChannelId: number;
    created: Date;
}

export interface IMessageResponseDTO {
    id: number;
    userId: string;
    text: string;
    textChannelId: number;
    created: string;
}

export interface IMessagePostDTO {
    text: string;
    textChannelId: number;
}

export interface IMessageState {
    loading: boolean;
    all: IMessage[];
}