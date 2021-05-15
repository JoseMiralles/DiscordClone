import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchUserServers, selectServer } from "../../Actions/ServerActions";
import { Modals } from "../../Models/ModalModel";
import { AppState } from "../../store";
import CreateServerButton from "./CreateServerButton"
import CreateServerModal from "./CreateServerModal";
import ServerBarItem from "./ServerBarItem";
import "./ServerBar.scss";

const ServerBar = () => {

    const dispatch = useDispatch();
    const { selectedModal, username, servers, selectedServer } = useSelector((s: AppState) => {
        return {
            selectedModal: s.modal.modal,
            username: s.users.users[s.session.userId].userName,
            servers: s.servers.all,
            selectedServer: s.servers.selected
        }
    });

    const barItems = Object.values(servers).map(s => (
        <ServerBarItem key={s.id} server={s} selected={selectedServer} />
    ));

    useEffect(() => {
        const act = async () => dispatch(await fetchUserServers());
        act();
    }, []);

    const onClick = ({ target }: any) => {
        dispatch(selectServer(target.id));
    };

    return (
        <section className="padded-component" id="server-bar-section">
            <div className="row">
                <CreateServerButton />
                <ul onClick={onClick} id="server-list">
                    {barItems}
                </ul>
            </div>
            {(selectedModal === Modals.createServer) && <CreateServerModal username={username}/>}
        </section>
    )
};

export default ServerBar;