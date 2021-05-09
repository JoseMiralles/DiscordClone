import { IServer } from "../../Models/ServerModel";

interface Props {
    server: IServer,
    selected: number | null
}

const ServerBarItem = ({ server, selected }: Props) => {

    const isSelected = (selected !== null) && (selected.toString() === server.id.toString());

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