import { serverRole } from "../../Models/ServerModel";
import { IUser } from "../../Models/UserModel";

interface Props {
    user: IUser,
    role: serverRole
}

const UserBarItem = ({ user, role }: Props) => {
    
    const className: string = user.online ? "online" : "offline";

    return (
        <li className="user-list-item">
            <div className="user-list-item-icon">{user.userName[0]}</div>
            <div className={className}>{user.userName}</div>
        </li>
    )
};

export default UserBarItem;