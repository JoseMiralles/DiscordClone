import { AppActions } from "../Models/AppModel";
import { IServerState } from "../Models/ServerModel";

const initialState: IServerState = {
    loading: false,
    selected: -1,
    all: {}
};

const serverReducer = (
    state: IServerState = initialState,
    action: AppActions
) => {
    switch (action.type) {

        case "FETCHING_SERVERS": {
            return {
                ...state,
                loading: true
            }
        }
            
        case "RECEIVE_SERVER": {
            return {
                loading: false,
                selected: action.server.id,
                all: {...state.all, [action.server.id]: action.server}
            }
        }
            
        case "RECEIVE_ALL_SERVERS": {
            return {
                loading: false,
                selected: -1,
                all: action.servers
            }
        }
            
        case "REMOVE_SERVER": {
            const servers = Object.assign({}, state.all);
            delete servers[action.serverId];
            return {
                loading: false,
                selected: -1,
                all: servers
            }
        }
        
        case "REMOVE_SESSION": {
            return initialState;
        }
            
        default: return state;

    }
};

export default serverReducer;