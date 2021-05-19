import { IMessage } from "../../Models/MessagesModel";
import { IUser } from "../../Models/UserModel";

interface Props {
    messages: { [Indexer: number]: IMessage };
    loading: boolean;
    textChannelId: number;
    users: { [Indexer: string]: IUser };
}

const MessagesList = ({ messages, loading, textChannelId, users }: Props) => {

    const mappedMessages: JSX.Element[] = [];
    Object.values(messages)
        // .sort((a, b) => (+a.created - +b.created))
        .forEach(m => {
            mappedMessages.push(
                <li key={m.id}>
                    <div className="main-message-wrapper">
                        <div className="user-message-icon">{users[m.userId]?.userName[0] || "..."}</div>
                        <div className="message-contents">
                            <div className="message-detail-row">
                                <div className="username">{users[m.userId]?.userName || "..."}</div>
                                <div className="date">{m.created.toLocaleDateString()}</div>
                            </div>
                            <div className="message-text">{m.text}</div>
                        </div>
                    </div>
                </li>
            );
    });

    return (
        <>
            { loading ? "loading..." : mappedMessages}
        </>
    );
};

export default MessagesList;