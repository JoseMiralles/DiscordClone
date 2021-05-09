import { AppActions } from "../Models/AppModel";
import { ISessionErrors, ISessionState } from "../Models/SessionModel";
import { getTokenSet } from "../Util/SessionUtil";

const initialState = {
    userId: "",
    loading: false,
    restoringSession: getTokenSet().refreshToken ? true : false
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
                userId: action.user.id,
                loading: false,
                restoringSession: false
            }
        }

        case "REMOVE_SESSION": return {
            userId: "",
            loading: false,
            restoringSession: false
        };

        case "RECEIVE_SESSION_ERRORS": {
            return {
                ...state,
                errors: action.errors,
                loading: false
            }
        }

        case "CLEAR_SESSION_ERRORS": return {
            ...state,
            errors: undefined
        }

        default: return state;
    }

}