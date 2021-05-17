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
    Object.values(messages).forEach(m => {
        if (m.textChannelId === textChannelId)
            mappedMessages.push(
                <li key={m.id}>
                    <div>{users[m.userId]?.userName || "..."}</div>
                    <div>{m.text}</div>
                </li>
            );
    });

    return (
        <ul>
            { loading ? "loading..." : mappedMessages}
        </ul>
    );
};

export default MessagesList;