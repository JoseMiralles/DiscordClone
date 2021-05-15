import { useDispatch } from "react-redux";
import { login } from "../../Actions/SessionActions";

interface Props {
    userNumber: number;
    loading: boolean;
}

const DemoLoginButton: React.FC<Props> = ({
    userNumber,
    loading,
    children
}) => {

    const dispatch = useDispatch();
    const email = `test${userNumber}@test.com`;
    const password = "Password123!";

    const clicked = () => {
        const act = async () => {
            dispatch(await login({ email, password}));
        };
        act();
    };

    return <button disabled = {loading ? true : false}
        className="btn btn-main" onClick={clicked}>{!loading ? children : "..."}</button>;
};

export default DemoLoginButton;