import { useDispatch } from "react-redux";
import { login } from "../../Actions/SessionActions";

interface Props {
    userNumber: number;
}

const DemoLoginButton: React.FC<Props> = ({
    userNumber,
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

    return <button className="btn btn-main" onClick={clicked}>{children}</button>;
};

export default DemoLoginButton;