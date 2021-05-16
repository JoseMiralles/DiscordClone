import { ITextChannelState } from "../Models/TextChannelModel";
import { AppActions } from "../store";

const defaultState: ITextChannelState = {
    loading: false,
    textChannels: [],
    selected: null
};

const textChannelsReducer = (
    state: ITextChannelState = defaultState,
    action: AppActions
): ITextChannelState => {

    switch (action.type) {

        case "RECEIVER_SERVER_TEXT_CHANNELS": {
            return {
                ...state,
                loading: false,
                textChannels: action.channels
            };
        }
            
        case "FETCHING_TEXT_CHANNELS": {
            return {
                ...state,
                loading: true
            }
        }
            
        case "SELECT_TEXT_CHANNEL": {
            return {
                ...state,
                selected: action.textChannelId
            }
        }
            
        default: return state;

    }

};

export default textChannelsReducer;