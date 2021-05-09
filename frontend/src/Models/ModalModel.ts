export const SET_MODAL = "SET_MODAL";
export const CLOSE_MODAL = "CLOSE_MODAL";

export interface ISetModal {
    type: "SET_MODAL";
    modal: Modals;
}

export interface ICloseModal {
    type: "CLOSE_MODAL";
}

export type ModalActionTypes =
    ISetModal |
    ICloseModal;

export interface IModalState {
    modal: Modals;
};

/**
 * Flags that define which modal should be shown.
 * This is done to avoid having multiple modals up at once.
 */
 export enum Modals {
     closed,
     createServer,
};