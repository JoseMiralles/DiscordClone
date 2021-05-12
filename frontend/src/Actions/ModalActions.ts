import { Modals } from "../Models/ModalModel";
import { AppActions } from "../store";

export const setModal = (modal: Modals): AppActions => ({
    type: "SET_MODAL",
    modal
});

export const closeModal = (): AppActions => ({
    type: "CLOSE_MODAL"
});