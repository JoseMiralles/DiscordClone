import { serverRole } from "../../Models/ServerModel";
import { IUser } from "../../Models/UserModel";

interface Props {
    user: IUser,
    role: serverRole
}

const UserBarItem = ({ user, role }: Props) => {
    return (
        <li>
            <div>{ user.online ? "O" : "X" }</div>
            <div>{user.userName}</div>
        </li>
    )
};

export default UserBarItem;