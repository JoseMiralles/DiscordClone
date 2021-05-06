import { AppActions } from "../Models/AppModel";
import { ISessionState } from "../Models/SessionModel";

const initialState = {
    userId: "",
    loading: false,
    restoringSession: true
};

export const sessionReducer = (state = initialState, action: AppActions): ISessionState => {

    switch (action.type) {

        case "GETTING_SESSION": {
            return {
                ...state,
                loading: true
            }
        }
            
        case "RECEIVE_SESSION": {
            return {
                userId: action.userId,
                loading: false,
                restoringSession: false
            }
        }
            
        case "REMOVE_SESSION": return {
            userId: "",
            loading: false,
            restoringSession: false
        };

        case "RECEIVE_SESSION_ERRORS": return {
            ...state,
            errors: action.errors,
            loading: false
        }
            
        default: return state;
    }

}