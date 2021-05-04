import "./NavBar.scss";
import { useDispatch, useSelector } from "react-redux";
import { Link } from "react-router-dom";
import { logout } from "../Actions/SessionActions";
import { IAppSate } from "../store";

interface Props {
    isAuthenticated: boolean
}

const NavBar = ({ isAuthenticated }: Props) => {

    const dispatch = useDispatch();

    return (
        <nav className="section">
            <div className="container" id="nav-bar">
                <div>
                    <div id="nav-logo" className="logo">InTalk</div>
                </div>
                <div id="nav-menu-button">
                    <div className="material-icons">menu</div>
                </div>
            </div>
            <div id="nav-menu-wrapper" className="container">
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