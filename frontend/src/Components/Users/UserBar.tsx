import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchServerUsers } from "../../Actions/ServerActions";
import { serverRole } from "../../Models/ServerModel";
import { IUser } from "../../Models/UserModel";
import { AppState } from "../../store";
import UserBarItem from "./UserBarItem";
import "./UserBar.scss"

const UserBar = () => {

    const dispatch = useDispatch();
    const { admins, members, serverId } = useSelector((s: AppState) => {
        
        const admins: JSX.Element[] = [];
        const members: JSX.Element[] = [];
        if (s.servers.selected) {
            const server = s.servers.all[s.servers.selected];
            if (server && server.usersServers) {
                s.servers.all[s.servers.selected].usersServers.forEach(us => {
                    const user: IUser = s.users.users[us.userId];
                    const el = (<UserBarItem key={user.id} user={user} role={us.role}/>);
                    (us.role === serverRole.owner)
                        ? admins.push(el)
                        : members.push(el);
                });
            }
        }
        return { admins, members, serverId: s.servers.selected };
    });

    useEffect(() => {
        if (serverId) {
            const act = async () => dispatch(await fetchServerUsers(serverId));
            act();
        }
    }, [serverId]);

    return (
        <section>
            <div>
                <span>ADMIN</span>
                <ul>
                    {admins}
                </ul>
            </div>
            <div>
                <span>MEMEBERS</span>
                <ul>
                    {members.length ? members : <li>No other members</li>}
                </ul>
            </div>
        </section>
    )
}

export default UserBar;