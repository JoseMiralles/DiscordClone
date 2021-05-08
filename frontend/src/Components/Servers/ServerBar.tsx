import { useSelector } from "react-redux";
import { Modals } from "../../Models/ModalModel";
import { AppState } from "../../store";
import CreateServerButton from "./CreateServerButton"
import CreateServerModal from "./CreateServerModal";

const ServerBar = () => {

    const selectedModal: Modals = useSelector((s: AppState) => s.modal.modal);

    return (
        <section id="server-bar-section">
            <ul id="server-list">
                <CreateServerButton />
            </ul>
            {(selectedModal === Modals.createServer) && <CreateServerModal/>}
        </section>
    )
};

export default ServerBar;