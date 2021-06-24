import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { getTextChannels, selectTextChannel } from "../../Actions/TextChannelsActions";
import { AppState } from "../../store";
import TextChannelBarItem from "./TextChannelBarItem";
import "./TextChannelBar.scss";
import { closeAllBars, setChannelBarVisibility } from "../../Actions/UIActions";

const TextChannelBar = () => {
    const dispatch = useDispatch();
    const { channels, loading, selected, serverId, visible } = useSelector((s: AppState) => {
        return {
            channels: s.textChannels.textChannels,
            loading: s.textChannels.loading,
            selected: s.textChannels.selected,
            serverId: s.servers.selected,
            visible: s.ui.channelBarVisibility
        }
    });

    useEffect(() => {
        serverId && dispatch(getTextChannels(serverId));
    }, [serverId]);

    const onClick = (e: any) => {
        dispatch(closeAllBars());
        dispatch(selectTextChannel(e.target.value));
    };

    const onVisivilityButtonClick = () => {
        if (visible === false) dispatch(closeAllBars());
        dispatch(setChannelBarVisibility(!visible));
    };

    const renderBarContent = () => {
        return (
            <>
                {
                    loading ?
                        <div>
                            loading ...
                        </div>
                        :
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
            </>
        );
    };

    const classExtra = visible ? "" : " no-padding";
    const buttonIcon = visible ? "chevron_left" : "chevron_right";

    return (
        <section id="channels-bar-section" className={classExtra}>
            <div className="relative">
                <div
                onClick={onVisivilityButtonClick}
                id="text-channel-visibility-button">
                    <span className="material-icons">
                        {buttonIcon}
                    </span>
                </div>
            </div>
            {visible && renderBarContent()}
        </section >
    );

};

export default TextChannelBar;