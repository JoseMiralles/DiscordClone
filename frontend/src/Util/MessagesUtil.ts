import axios, { AxiosResponse } from "axios";
import { IMessage, IMessagePostDTO } from "../Models/MessagesModel";

export const fetchChannelMessagesUtil = async (channelId: number): Promise<IMessage[]> => {
    return (await axios.get(`/api/TextChannels/${channelId}/Messages`)).data;
};

export const postMessageUtil = async (messageDTO: IMessagePostDTO): Promise<IMessage> => {
    const res = await axios.post("/api/Messages", messageDTO);
    return res.data;
};

export const deleteMessageUtil = async (messageId: number): Promise<IMessage> => {
    return (await axios.delete(`/api/Messages/${messageId}`)).data;
};