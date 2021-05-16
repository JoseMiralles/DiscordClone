import TextChannelBar from "../TextChannels/TextChannelBar";
import UserBar from "../Users/UserBar"
import "./ServerView.scss"

const ServerView = () => {

    return (
        <section id="server-view-section">
            <section id="channels-bar-section"></section>
            <TextChannelBar/>
            <UserBar/>
        </section>
    );
};

export default ServerView;