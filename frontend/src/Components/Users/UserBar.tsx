import { useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { fetchServerUsers } from "../../Actions/ServerActions";
import { IUserServer, serverRole } from "../../Models/ServerModel";
import { IUser } from "../../Models/UserModel";
import { AppState } from "../../store";
import UserBarItem from "./UserBarItem";
import "./UserBar.scss"
import { closeAllBars, setUserVarVisibility } from "../../Actions/UIActions";

const UserBar = () => {

    const dispatch = useDispatch();
    const { admins, members, offline, serverId, visible } = useSelector((s: AppState) => {

        const admins: JSX.Element[] = [];
        const members: JSX.Element[] = [];
        const offline: JSX.Element[] = [];
        if (s.servers.selected) {
            const server = s.servers.all[s.servers.selected];
            if (server && server.usersServers) {
                s.servers.all[s.servers.selected].usersServers.forEach(us => {
                    const user: IUser = s.users.users[us.userId];
                    const el = (<UserBarItem key={user.id} user={user} role={us.role} />);
                    if (user.online) {
                        (us.role === serverRole.owner)
                            ? admins.push(el)
                            : members.push(el);
                    } else {
                        offline.push(el);
                    }
                });
            }
        }
        return { admins, members, offline, serverId: s.servers.selected, visible: s.ui.userBarVisibility };
    });

    useEffect(() => {
        if (serverId) {
            const act = async () => dispatch(await fetchServerUsers(serverId));
            act();
        }
    }, [serverId]);

    const onUserBarVisibilityButtonClick = (e: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
        if (visible === false) dispatch(closeAllBars());
        dispatch(setUserVarVisibility(!visible));
    };

    const extraClass = visible ? "" : " no-padding";
    const btnIcon = visible ? "chevron_right" : "people";

    return (
        <section id={"user-bar-section"} className={extraClass}>
            <div className="relative">
                <div
                    onClick={onUserBarVisibilityButtonClick}
                    id="user-bar-show-button">
                    <span className="material-icons">{btnIcon}</span>
                </div>
            </div>
            {visible &&
                <>
                    <div className="user-list-wrapper">
                        <div className="user-list-title">ADMIN - {admins.length}</div>
                        <ul className="user-list">
                            {admins}
                        </ul>
                    </div>
                    <div className="user-list-wrapper">
                        <div className="user-list-title">MEMEBERS - {members.length}</div>
                        <ul className="user-list">
                            {members.length ? members : <li>No other members</li>}
                        </ul>
                    </div>
                    <div className="user-list-wrapper">
                        <div className="user-list-title">OFFLINE - {offline.length}</div>
                        <ul className="user-list offline-list">
                            {offline.length ? offline : <li>No other offline</li>}
                        </ul>
                    </div>
                </>
            }
        </section>
    )
}

export default UserBar;