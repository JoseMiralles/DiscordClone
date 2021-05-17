import { IMessage, IMessageState } from "../Models/MessagesModel";
import { AppActions } from "../store";

const initialState: IMessageState = {
    loading: false,
    all: {}
};

const MessagesReducer = (
    state: IMessageState = initialState, action: AppActions
): IMessageState => {

    switch (action.type) {

        case "FETCHING_MESSAGES": {
            return {
                ...state,
                loading: true
            }
        }
        
        case "RECEIVE_ALL_MESSAGES": {
            const all: { [Indexer: number]: IMessage } = {};
            action.messages.forEach(m => all[m.id] = m);
            return {
                ...state,
                loading: false,
                all
            };
        }
            
        case "RECEIVE_ONE_MESSAGE": {
            return {
                ...state,
                loading: false,
                all: {
                    ...state.all,
                    [action.message.id]: action.message
                }
            }
        }
            
        case "REMOVE_MESSAGE": {
            const all = Object.assign({}, state.all);
            delete all[action.id];
            return {
                ...state,
                loading: false,
                all
            }
        }
            
        default: return state;

    }

}

export default MessagesReducer;