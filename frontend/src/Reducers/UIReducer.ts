import { IUIState } from "../Models/UIModel";
import { AppActions } from "../store";

const defaultState: IUIState = {
    userBarVisibility: false,
    channelBarVisibility: true
}

const UIReducer = (
    state: IUIState = defaultState, action: AppActions
): IUIState => {

    switch ( action.type ) {

        case "SET_USER_BAR_VISIBILITY": {
            return {
                ...state,
                userBarVisibility: action.visible
            }
        }

        case "SET_CHANNEL_BAR_VISIBILITY": {
            return {
                ...state,
                channelBarVisibility: action.visible
            }
        }

        default: { return state; }

    }

};

export default UIReducer;