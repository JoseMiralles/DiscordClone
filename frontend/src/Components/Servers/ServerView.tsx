import UserBar from "../Users/UserBar"
import "./ServerView.scss"

const ServerView = () => {

    return (
        <section id="server-view-section">
            <section id="channels-bar-section"></section>
            <section id="chat-section"></section>
            <UserBar/>
        </section>
    );
};

export default ServerView;