import { useDispatch } from "react-redux";
import { login } from "../../Actions/SessionActions";

const DemoLoginButton = () => {
    const dispatch = useDispatch();

    const clicked = () => {
        const act = async () => {
            dispatch(await login({
                email: "test1@test.com",
                password: "Password123!"
            }));
        };
        act();
    };

    return <button className="btn btn-main" onClick={clicked}>Test</button>;
};

export default DemoLoginButton;