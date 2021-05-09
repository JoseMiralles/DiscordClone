import { AppActions } from "../Models/AppModel";
import { IServer, IServerState, serverRole } from "../Models/ServerModel";

const initialState: IServerState = {
    loading: false,
    selected: null,
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
            const newAll: {[Identifier: number]: IServer} = {};
            action.servers.forEach(s => {newAll[s.id] = s});
            return {
                loading: false,
                selected: null,
                all: newAll
            }
        }
            
        case "RECEIVE_SERVER_USERS": {
            const updatedServer: IServer = {
                ...state.all[action.serverId],
                usersServers: action.users.map(u => ({
                    role: u.role,
                    userId: u.userId
                }))
            };
            const newAll = {
                ...state.all
            };
            newAll[updatedServer.id] = updatedServer;
            return {
                ...state,
                loading: false,
                all: newAll
            }
        }
            
        case "REMOVE_SERVER": {
            const servers = Object.assign({}, state.all);
            delete servers[action.serverId];
            return {
                loading: false,
                selected: null,
                all: servers
            }
        }
        
        case "REMOVE_SESSION": {
            return initialState;
        }
            
        case "SELECT_SERVER": {
            return {
                ...state,
                selected: action.serverId
            }
        }
            
        default: return state;

    }
};

export default serverReducer;