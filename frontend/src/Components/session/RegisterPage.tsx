import { useState } from "react";
import { useDispatch } from "react-redux";
import { register } from "../../Actions/SessionActions";
import DemoLoginButton from "./DemoLoginButton";

const RegisterPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const act = async () => {
            dispatch(await register({
                email, username, password
            }));
        };
        act();
    };

    return (
        <section className="auth-form-section">
            <div className="container">
                <div className="auth-form-wrapper">

                    <div className="auth-form-title">Register</div>

                    <form className="auth-form" onSubmit={onSubmit}>
                        <label htmlFor="email">Email:</label>
                        <input type="text" id="email"
                            value={email}
                            onChange={(e) => { setEmail(e.target.value) }} />

                        <label htmlFor="username">User name:</label>
                        <input type="text" id="username"
                            value={username}
                            onChange={(e) => { setUsername(e.target.value) }} />

                        <label htmlFor="password">Password:</label>
                        <input type="password" id="password"
                            value={password}
                            onChange={(e) => { setPassword(e.target.value) }} />

                        <DemoLoginButton userNumber={1}>user 1</DemoLoginButton>

                        <button className="btn btn-main">submit</button>
                    </form>
                </div>
            </div>
        </section>
    );
};

export default RegisterPage;