import { useState } from "react";
import { useDispatch } from "react-redux";
import { createMessage } from "../../Actions/MessageActions";

interface Props {
    channelName: string | undefined,
    channelId: number | null
}

const MessageInput = ({ channelName, channelId }: Props) => {

    const dispatch = useDispatch();
    const [message, setMessage] = useState("");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const act = async () => {
            if (channelId) {
                dispatch(await createMessage({
                    text: message,
                    textChannelId: channelId
                }));
                setMessage("");
            }
        };
        act();
    };

    return (
        <div id="message-input">
            <form onSubmit={onSubmit}>
                <input
                    type="text"
                    placeholder={"message " + channelName}
                    value={message}
                    onChange={(e)=>{setMessage(e.target.value)}}
                />
            </form>
        </div>
    );
};

export default MessageInput;