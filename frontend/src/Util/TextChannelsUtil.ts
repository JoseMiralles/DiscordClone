import axios from "axios";
import { ICreateTextChannelDTO, ITextChannel } from "../Models/TextChannelModel";
import { baseAPIUrl } from "./EnviromentUtil";

export const fetchServerTextChannelsUtil = async (serverId: number): Promise<ITextChannel[]> => {
    const req = await axios.get(`/api/Server/${serverId}/TextChannels`);
    return req.data;
};

export const postNewTextChannelUtil = async (newChannel: ICreateTextChannelDTO): Promise<ITextChannel> => {
    const req = await axios.post("/api/TextChannels", newChannel);
    return req.data;
};