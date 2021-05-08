import { useState } from "react";
import { useDispatch } from "react-redux";
import { closeModal } from "../../Actions/ModalActions";

const CreateServerModal = () => {

    const dispatch = useDispatch();
    const [serverName, setServerName] = useState("");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
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