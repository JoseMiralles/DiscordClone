import { useDispatch } from "react-redux";
import { setModal } from "../../Actions/ModalActions";
import { Modals } from "../../Models/ModalModel";

const CreateServerButton = () => {

    const dispatch = useDispatch();

    const onClick = () => {
        dispatch(setModal(Modals.createServer));
    };

    return (
        <div onClick={onClick}>
            <div>
                <div id="new-server-button" className="material-icons btn">add</div>
            </div>
        </div>
    );
};

export default CreateServerButton;