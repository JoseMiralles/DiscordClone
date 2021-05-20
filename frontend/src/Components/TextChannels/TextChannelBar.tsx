import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { getTextChannels, selectTextChannel } from "../../Actions/TextChannelsActions";
import { AppState } from "../../store";
import TextChannelBarItem from "./TextChannelBarItem";
import "./TextChannelBar.scss";

const TextChannelBar = () => {

    const dispatch = useDispatch();
    const { channels, loading, selected, serverId } = useSelector((s: AppState) => {
        return {
            channels: s.textChannels.textChannels,
            loading: s.textChannels.loading,
            selected: s.textChannels.selected,
            serverId: s.servers.selected
        }
    });

    useEffect(() => {
        serverId && dispatch(getTextChannels(serverId));
    }, [serverId]);

    const onClick = (e: any) => {
        dispatch(selectTextChannel(e.target.value));
    };

    return (
        <section id="channels-bar-section">
            {
                loading ?
                    <div>
                        loading ...
                    </div> :
                    <div>
                        <div className="text-channel-bar-title">TEXT CHANNELS</div>
                        <ul onClick={onClick} className="channel-list">
                            {channels.map(c =>
                                <TextChannelBarItem
                                    key={c.id}
                                    channel={c}
                                    selected={selected === c.id} />
                            )}
                        </ul>
                    </div>
                }
        </section>
    );

};

export default TextChannelBar;