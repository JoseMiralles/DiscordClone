import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { getChannelMessages } from "../../Actions/MessageActions";
import { AppState } from "../../store";
import MessageInput from "./MessageInput";
import MessagesList from "./MessagesList";
import "./MessagesSection.scss";

const MessagesSection = () => {

    const dispatch = useDispatch();
    const { messages, loading, selectedTextChannelId, users, channelName } = useSelector((s: AppState) => {
        return {
            messages: s.messages.all,
            loading: s.messages.loading,
            selectedTextChannelId: s.textChannels.selected,
            users: s.users.users,
            channelName: s.textChannels.textChannels.find(tc => tc.id === s.textChannels.selected)?.title
        };
    });

    useEffect(() => {
        const act = async () => {
            selectedTextChannelId && dispatch(await getChannelMessages(selectedTextChannelId));
        };
        act();
    }, [selectedTextChannelId]);

    return (
        <section id="chat-section">
            <div id="chat-title">{ channelName }</div>
            <div id="chat-messages-list">
                {selectedTextChannelId &&
                    <MessagesList
                    messages={messages}
                    loading={loading}
                    textChannelId={selectedTextChannelId}
                    users={users} />}
            </div>
            <MessageInput channelId={selectedTextChannelId} channelName={channelName} />
        </section>
    );
};

export default MessagesSection;