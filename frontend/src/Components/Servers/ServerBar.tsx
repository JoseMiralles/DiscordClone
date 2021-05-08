import { useSelector } from "react-redux";
import { Modals } from "../../Models/ModalModel";
import { AppState } from "../../store";
import CreateServerButton from "./CreateServerButton"
import CreateServerModal from "./CreateServerModal";

const ServerBar = () => {

    const { selectedModal, username } = useSelector((s: AppState) => {
        return {
            selectedModal: s.modal.modal,
            username: s.users.users[s.session.userId].userName
        }
    });

    return (
        <section id="server-bar-section">
            <ul id="server-list">
                <CreateServerButton />
            </ul>
            {(selectedModal === Modals.createServer) && <CreateServerModal username={username}/>}
        </section>
    )
};

export default ServerBar;