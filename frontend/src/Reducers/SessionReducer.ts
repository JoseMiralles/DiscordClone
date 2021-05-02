import { GETTING_SESSION, RECEIVE_SESSION, REMOVE_SESSION, SessionActions } from "../Actions/SessionActions";
import { ISessionState } from "../Models/SessionModel";

const initialState: ISessionState = {
    userId: null,
    jwt: null,
    loading: false
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
                jwt: action.session.jwt,
                loading: false
            }
        }
            
        case REMOVE_SESSION: {
            return initialState;
        }
            
        default: return state;
    }

}