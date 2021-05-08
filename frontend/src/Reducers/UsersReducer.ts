import { AppActions } from "../Models/AppModel";
import { IUserState, IUser } from "../Models/UserModel";

const initialState: IUserState = {
    users: {}
};

export const usersReducer = (
    state: IUserState = initialState,
    action: AppActions
): IUserState => {

    switch (action.type) {

        case "RECEIVE_SESSION":
        case "RECEIVE_USER": {
            const newState = Object.assign({}, state);
            newState.users[action.user.id] = action.user;
            return state;
        }
            
        case "RECEIVE_SERVER_USERS": {
            const newState = Object.assign({}, state);
            action.users.forEach(u => newState.users[u.id] = u);
            return newState;
        }
            
        case "REMOVE_SESSION": {
            return { users: {} };
        }
            
        default: return state;

    }

};
