import { useSelector } from "react-redux";
import { AppState } from "../store";
import ServerBar from "./Servers/ServerBar"
import UserBar from "./Users/UserBar";
import * as SignalR from "@microsoft/signalr";
import { getTokenSet } from "../Util/SessionUtil";

const Client = () => {

    const selected = useSelector((s: AppState) => s.servers.selected);

    // Add this to a custom hook.
    const connection = new SignalR.HubConnectionBuilder()
        .withUrl("https://localhost:5001/hubs/intalk",
            { accessTokenFactory: () => getTokenSet().jwt })
        .build();
    
    connection.on("messageReceived", (message: string) => {
        console.log(message);
    });

    connection.start().then(() => {
        connection.send("ChangeRole", "hi!");
    });

    return (
        <section id="client-section">
            <ServerBar />
            { selected !== null && <UserBar/> }
        </section>
    );
};

export default Client;