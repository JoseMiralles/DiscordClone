import { useState } from "react";
import { useDispatch } from "react-redux";
import { closeModal, setModal } from "../../Actions/ModalActions";
import { createServer } from "../../Actions/ServerActions";
import { Modals } from "../../Models/ModalModel";

interface Props {
    username: string;
}

const CreateServerModal = (props: Props) => {

    const dispatch = useDispatch();
    const [serverName, setServerName] = useState(props.username + "'s server");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const act = async () => {
            dispatch(await createServer({
                title: serverName
            }));
            dispatch(setModal(Modals.closed));
        };
        act();
    };

    const close = () => {
        dispatch(closeModal());
    };

    return (
        <section className="modal-section">
            <div className="modal-wrapper">
                <div className="modal">
                    <div className="modal-title">
                        <h1>Create Server</h1>
                    </div>
                    <div>
                        <button onClick={close} className="material-icons btn modal-close">close</button>
                    </div>
                    <form className="modal-form" onSubmit={onSubmit}>
                        <label htmlFor="server-name">SERVER NAME</label>
                        <input type="text" id="server-name"
                            value={serverName}
                            onChange={(e) => { setServerName(e.target.value) }} />
                        
                        <button className="btn btn-main">Create</button>
                    </form>
                </div>
            </div>
            <div onClick={close} className="modal-background"></div>
        </section>
    );
};

export default CreateServerModal;