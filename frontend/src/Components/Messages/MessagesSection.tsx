import React, { createRef, EffectCallback, useLayoutEffect, useRef, useState } from "react";
import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { getChannelFirstMessages, getMoreChannelMessages } from "../../Actions/MessageActions";
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

    const messagesList = useRef<HTMLDivElement>(null);
    const innerUl = useRef<HTMLUListElement>(null);
    const [stickToBottom, setStickToBottom] = useState(true);

    useLayoutEffect(() => {
        if (stickToBottom && messagesList.current){
            messagesList.current.scrollTop = messagesList.current.scrollHeight;
        }
        if (messagesList.current && innerUl.current &&
            innerUl.current?.clientHeight <= messagesList.current?.clientHeight) {
            if (selectedTextChannelId) {
                const act = async () => dispatch(await getMoreChannelMessages(selectedTextChannelId, messages.length));
                act();
            }
        }
    }, [messages]);

    useEffect(() => {
        const act = async () => {
            selectedTextChannelId && dispatch(await getChannelFirstMessages(selectedTextChannelId));
        };
        act();
    }, [selectedTextChannelId]);

    const onScroll = async (e: React.UIEvent<HTMLDivElement, UIEvent>) => {
        if (e.currentTarget.scrollTop === 0 && selectedTextChannelId) {
            dispatch(await getMoreChannelMessages(selectedTextChannelId, messages.length));
        } else if (e.currentTarget.scrollTop === e.currentTarget.scrollHeight) {
            console.log("true");
            setStickToBottom(true);
        } else {
            console.log("false");
            setStickToBottom(false);
        }
    };

    return (
        <section id="chat-section">
            <div id="chat-title">{ channelName }</div>
            <div id="chat-messages-list" ref={messagesList} onScroll={onScroll}>
                {selectedTextChannelId &&
                    <ul ref={innerUl}>
                        <MessagesList
                        messages={messages}
                        loading={loading}
                        textChannelId={selectedTextChannelId}
                            users={users} />
                    </ul>
                }
                
            </div>
            <MessageInput channelId={selectedTextChannelId} channelName={channelName} />
        </section>
    );
};

export default MessagesSection;