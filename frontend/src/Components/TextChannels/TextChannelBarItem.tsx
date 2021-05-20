import { ITextChannel } from "../../Models/TextChannelModel";

interface Props {
    channel: ITextChannel;
    selected: boolean;
}

const TextChannelBarItem = ({ channel, selected }: Props) => {
    return (
        <li
            value={channel.id}
            className={selected ? "selected" : ""}>
            <span className="text-channel-icon">#</span> {channel.title}
        </li>
    );
};

export default TextChannelBarItem;