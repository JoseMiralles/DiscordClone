import { GETTING_SESSION, RECEIVE_SESSION, REMOVE_SESSION, SessionActions } from "../Actions/SessionActions";
import { ISessionState } from "../Models/SessionModel";
import { getTokenSet } from "../Util/SessionUtil";

const getInitalState = (): ISessionState => {
    return {
        userId: getTokenSet().refreshToken ? "..." : null,
        loading: false
    }
};

export const sessionReducer = (state: ISessionState = getInitalState(), action: SessionActions) => {

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
                loading: false
            }
        }
            
        case REMOVE_SESSION: return getInitalState();
            
        default: return state;
    }

}