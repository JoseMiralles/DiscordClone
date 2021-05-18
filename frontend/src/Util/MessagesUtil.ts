import axios, { AxiosResponse } from "axios";
import { IMessage, IMessagePostDTO, IMessageResponseDTO } from "../Models/MessagesModel";

export const fetchChannelMessagesUtil = async (
    channelId: number,
    offset: number = 0
): Promise<IMessageResponseDTO[]> => {
    return (await axios.get(`/api/TextChannels/${channelId}/Messages/${offset}`)).data;
};

export const postMessageUtil = async (messageDTO: IMessagePostDTO): Promise<IMessageResponseDTO> => {
    const res = await axios.post("/api/Messages", messageDTO);
    return res.data;
};

export const deleteMessageUtil = async (messageId: number): Promise<IMessageResponseDTO> => {
    return (await axios.delete(`/api/Messages/${messageId}`)).data;
};