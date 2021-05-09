import { IServer } from "../../Models/ServerModel";

interface Props {
    server: IServer,
    selected: number
}

const ServerBarItem = ({ server, selected }: Props) => {
    
    return (
        <li>
            <button id={server.id.toString()} className="server-icon">{ server.title[0] }</button>
            { selected === server.id && <span>{ server.title }</span> }
        </li>
    );
};

export default ServerBarItem;