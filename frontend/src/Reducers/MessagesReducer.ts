import { IMessage, IMessageState } from "../Models/MessagesModel";
import { AppActions } from "../store";

const initialState: IMessageState = {
    loading: false,
    all: []
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
        
        case "RECEIVE_FIRST_MESSAGES": {
            return {
                ...state,
                loading: false,
                all: action.messages
            };
        }
            
        case "RECEIVE_MORE_MESSAGES": {
            return {
                ...state,
                loading: false,
                all: state.all.concat(action.messages)
            }
        }
            
        case "RECEIVE_ONE_MESSAGE": {
            return {
                ...state,
                loading: false,
                all: state.all.concat([action.message])
            }
        }
            
        case "REMOVE_MESSAGE": {
            return {
                ...state,
                loading: false,
                all: state.all.filter(m => m.id !== action.id)
            }
        }
            
        default: return state;

    }

}

export default MessagesReducer;