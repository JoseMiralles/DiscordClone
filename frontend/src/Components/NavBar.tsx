import { useSelector } from "react-redux";
import { Link } from "react-router-dom";
import { IAppSate } from "../store";

interface Props {
    isAuthenticated: boolean
}

const NavBar = ({ isAuthenticated }: Props) => {
    return (
        <nav>
            <div>
                <div>
                    <h3>InTalk</h3>
                </div>
                <div>
                    {!isAuthenticated
                        ? <>
                            <Link to="/login">login</Link>
                            <Link to="/register">register</Link>
                        </>
                        : <Link to="/logout">logout</Link>}
                </div>
            </div>
        </nav>
    );
};

export default NavBar;