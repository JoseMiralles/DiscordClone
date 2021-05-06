import { GETTING_SESSION, RECEIVE_SESSION, RECEIVE_SESSION_ERRORS, REMOVE_SESSION, SessionActions } from "../Actions/SessionActions";
import { ISessionState } from "../Models/SessionModel";

const initialState: ISessionState = {
    userId: null,
    loading: false,
    restoringSession: true
};

export const sessionReducer = (state: ISessionState = initialState, action: SessionActions) => {

    Object.freeze(state);

    switch (action.type) {

        case GETTING_SESSION: {
            return {
                ...state,
                loading: true
            }
        }
            
        case RECEIVE_SESSION: {
            return {
                userId: action.session.userId,
                loading: false,
                restoringSession: false
            }
        }
            
        case REMOVE_SESSION: return {
            userId: null,
            loading: false,
            restoringSession: false
        };

        case RECEIVE_SESSION_ERRORS: return {

        }
            
        default: return state;
    }

}