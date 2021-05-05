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
        <nav className="section" id="nav-section">
            <div className="container">
                <div id="nav-bar">
                    <div>
                        <Link to="/"><div id="nav-logo" className="logo">InTalk</div></Link>
                    </div>
                    <div onClick={flipMenu} id="nav-menu-button">
                        <div className="material-icons">{ icon }</div>
                    </div>
                </div>
                <div onClick={itemSelected} id="nav-menu-wrapper" className={`${menuClass}`}>
                    <ul id="nav-menu">
                        {!isAuthenticated
                            ? <>
                                <Link to="/login"><li>login</li></Link>
                                <Link to="/register"><li className="btn btn-main">register</li></Link>
                            </>
                            : <li><button className="btn" onClick={() => dispatch(logout())}>logout</button></li>
                        }
                    </ul>
                </div>
            </div>
        </nav>
    );
};

export default NavBar;