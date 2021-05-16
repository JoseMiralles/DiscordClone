import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { getTextChannels } from "../../Actions/TextChannelsActions";
import { AppState } from "../../store";

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

    return (
        <section id="chat-section">
            {
                loading ?
                    <div>
                        loading ...
                    </div> :
                    <div>
                        <ul>
                            {channels.map(c =>
                                <li
                                    key={c.id}
                                    className={(c.id === selected) ? "selected" : ""}>
                                    {c.title}
                                </li>
                            )}
                        </ul>
                    </div>
                }
        </section>
    );

};

export default TextChannelBar;