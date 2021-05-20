import MessagesSection from "../Messages/MessagesSection";
import TextChannelBar from "../TextChannels/TextChannelBar";
import UserBar from "../Users/UserBar"
import "./ServerView.scss"

const ServerView = () => {

    return (
        <section id="server-view-section">
            <TextChannelBar/>
            <MessagesSection />
            <UserBar/>
        </section>
    );
};

export default ServerView;