import { useSelector } from "react-redux";
import { AppState } from "../store";
import ServerBar from "./Servers/ServerBar"
import UserBar from "./Users/UserBar";

const Client = () => {

    const selected = useSelector((s: AppState) => s.servers.selected);

    return (
        <section id="client-section">
            <ServerBar />
            { selected !== -1 && <UserBar/> }
        </section>
    );
};

export default Client;