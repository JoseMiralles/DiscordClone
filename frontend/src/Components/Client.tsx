import { useSelector } from "react-redux";
import { AppState } from "../store";
import ServerBar from "./Servers/ServerBar"
import ServerView from "./Servers/ServerView";
import "./Client.scss";

const Client = () => {

    const { selected } = useSelector((s: AppState) => {
        return {
            selected: s.servers.selected,
        }
    });

    return (
        <section id="client-section">
            <ServerBar />
            {selected ? <ServerView /> : ""}
        </section>
    );
};

export default Client;