import { AppActions } from "../Models/AppModel";
import { IModalState, Modals } from "../Models/ModalModel";

const initialState: IModalState = {
    modal: Modals.closed
};

export const modalReducer = (
    state: IModalState = initialState,
    action: AppActions
): IModalState => {

    switch (action.type) {
        case "SET_MODAL": {
            return {
                ...state,
                modal: action.modal
            }
        }
            
        case "CLOSE_MODAL":
        case "REMOVE_SESSION": {
            return {
                ...state,
                modal: Modals.closed
            }
        }
            
        default: return state;
    }
    
};

export default modalReducer;