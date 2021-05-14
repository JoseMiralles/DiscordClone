import { IUserState, IUser } from "../Models/UserModel";
import { AppActions } from "../store";

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
            action.users.forEach(u => newState.users[u.userId] = ({
                id: u.userId,
                userName: u.userName
            }));
            return newState;
        }
            
        case "RECEIVE_ALL_ONLINE_USERS": {
            const newState = { ...state }
            action.userIds.forEach(userId => {
                if (userId) {newState.users[userId].online = true}
            });
            return newState;
        }
            
        case "RECEIVE_USER_STATUS": {
            const newState = { ...state };
            newState.users[action.userId].online = action.isOnline;
            return newState;
        }
            
        case "REMOVE_SESSION": {
            return { users: {} };
        }
            
        default: return state;

    }

};
