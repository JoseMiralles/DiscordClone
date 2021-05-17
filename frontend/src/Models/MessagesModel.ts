export const FETCHING_MESSAGES = "FETCHING_MESSAGES";
export const RECEIVE_ALL_MESSAGES = "RECEIVE_ALL_MESSAGES";
export const RECEIVE_ONE_MESSAGE = "RECEIVE_ONE_MESSAGE";
export const REMOVE_MESSAGE = "REMOVE_MESSAGE";

export interface IFetchingMessages {
    type: "FETCHING_MESSAGES"
}

export interface IReceiveAllMessages {
    type: "RECEIVE_ALL_MESSAGES";
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
    IReceiveAllMessages |
    IReceiveOneMessage |
    IRemoveMessage |
    IFetchingMessages;


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
    all: {[Indexer: number]: IMessage};
}