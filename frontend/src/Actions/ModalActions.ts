import { AppActions } from "../Models/AppModel";
import { Modals } from "../Models/ModalModel";

export const setModal = (modal: Modals): AppActions => ({
    type: "SET_MODAL",
    modal
});

export const closeModal = (): AppActions => ({
    type: "CLOSE_MODAL"
});