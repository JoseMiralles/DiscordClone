import { useDispatch } from "react-redux";
import { setModal } from "../../Actions/ModalActions";
import { Modals } from "../../Models/ModalModel";

const CreateServerButton = () => {

    const dispatch = useDispatch();

    const onClick = () => {
        dispatch(setModal(Modals.createServer));
    };

    return (
        <li onClick={onClick} id="create-server-button">
            <button className="circular-button btn">
                <span className="material-icons">add</span>
            </button>
        </li>
    );
};

export default CreateServerButton;