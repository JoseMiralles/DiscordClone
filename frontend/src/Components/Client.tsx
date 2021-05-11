import { useSelector } from "react-redux";
import { AppState } from "../store";
import ServerBar from "./Servers/ServerBar"
import UserBar from "./Users/UserBar";
import * as SignalR from "@microsoft/signalr";
import { getTokenSet } from "../Util/SessionUtil";
import { useEffect, useState } from "react";

const Client = () => {

    const selected = useSelector((s: AppState) => s.servers.selected);
    const [connection, setConnection] = useState<SignalR.HubConnection | null>(null);

    useEffect(() => {
        // TODO: Add this to a custom hook.
        const c = new SignalR.HubConnectionBuilder()
            .withUrl("https://localhosts:5001/hubs/intalk",
                { accessTokenFactory: () => getTokenSet().jwt })
            .build();

        c.on("messageReceived", (message: string) => {
            console.log(message);
        });

        c.start().then(() => {
            c.send("ChangeRole", "hi!");
            setConnection(c);
        });
    }, []);

    return (
        <section id="client-section">
            <ServerBar />
            { selected !== null && <UserBar />}
        </section>
    );
};

export default Client;