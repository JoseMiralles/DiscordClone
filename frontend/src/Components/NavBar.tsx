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
                        : <button onClick={()=>dispatch(logout())}>logout</button>}
                </div>
            </div>
        </nav>
    );
};

export default NavBar;