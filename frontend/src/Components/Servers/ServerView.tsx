import TextChannelBar from "../TextChannels/TextChannelBar";
import UserBar from "../Users/UserBar"
import "./ServerView.scss"

const ServerView = () => {

    return (
        <section id="server-view-section">
            <TextChannelBar/>
            <section id="chat-section"></section>
            <UserBar/>
        </section>
    );
};

export default ServerView;