import "./NavBar.scss";
import { useDispatch, useSelector } from "react-redux";
import { Link } from "react-router-dom";
import { logout } from "../Actions/SessionActions";
import { IAppSate } from "../store";
import { useState } from "react";

interface Props {
    isAuthenticated: boolean
}

const NavBar = ({ isAuthenticated }: Props) => {

    const dispatch = useDispatch();

    const [menuClosed, setMenuClosed] = useState(true);

    const flipMenu = () => setMenuClosed(!menuClosed);
    const itemSelected = () => setMenuClosed(true);

    const menuClass = menuClosed ? "hidden" : "";
    const icon = menuClosed ? "menu" : "close";

    return (
        <nav className="section">
            <div className="container" id="nav-bar">
                <div>
                    <div id="nav-logo" className="logo">InTalk</div>
                </div>
                <div onClick={flipMenu} id="nav-menu-button">
                    <div className="material-icons">{ icon }</div>
                </div>
            </div>
            <div onClick={itemSelected} id="nav-menu-wrapper" className={`container ${menuClass}`}>
                <ul id="nav-menu">
                    {!isAuthenticated
                        ? <>
                            <li><Link to="/login">login</Link></li>
                            <li><Link to="/register">register</Link></li>
                        </>
                        : <li><button onClick={() => dispatch(logout())}>logout</button></li>
                    }
                </ul>
            </div>
        </nav>
    );
};

export default NavBar;