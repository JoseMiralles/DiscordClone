import { serverRole } from "../../Models/ServerModel";
import { IUser } from "../../Models/UserModel";

interface Props {
    user: IUser,
    role: serverRole
}

const UserBarItem = ({ user, role }: Props) => {
    return (
        <li>{ user.userName + " " + role }</li>
    )
};

export default UserBarItem;