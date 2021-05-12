import { useSelector } from "react-redux";
import { AppState } from "../store";
import ServerBar from "./Servers/ServerBar"
import UserBar from "./Users/UserBar";
import * as SignalR from "@microsoft/signalr";
import { getTokenSet } from "../Util/SessionUtil";
import { useEffect, useState } from "react";

const Client = () => {

    const { selected, servers } = useSelector((s: AppState) => {
        return {
            selected: s.servers.selected,
            servers: Object.values(s.servers.all).map(s => s.id)
        }
    });
    const [connection, setConnection] = useState<SignalR.HubConnection | null>(null);

    useEffect(() => {
        // TODO: Add this to a custom hook.
        const c = new SignalR.HubConnectionBuilder()
            .withUrl("https://localhost:5001/hubs/intalk",
                { accessTokenFactory: () => getTokenSet().jwt })
            .build();

        c.on("messageReceived", (message: string) => {
            console.log(message);
        });

        c.on("WentOnline", (message: string) => {
            console.log(message);
        });

        c.start().then(() => {
            c.send("GoOnline", {groups: [-1,-2,-3]});
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