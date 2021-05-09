import { IServer } from "../../Models/ServerModel";

interface Props {
    server: IServer,
    selected: number
}

const ServerBarItem = ({ server, selected }: Props) => {

    const isSelected = selected.toString() === server.id.toString();

    return (
        <li>
            <div>
                <div id={server.id.toString()} className={`btn ${isSelected && "selected"}`}>
                    { isSelected ? server.title : server.title[0] }
                </div>
            </div>
        </li>
    );
};

export default ServerBarItem;