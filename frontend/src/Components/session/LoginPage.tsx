import { useState } from "react";
import { useDispatch } from "react-redux";
import "./AuthPage.scss";
import { login } from "../../Actions/SessionActions";

const LoginPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const act = async () => {
            dispatch(await login({
                email, password
            }));
        };
        act();
    };

    return (
        <section className="auth-form-section">
            <div className="container">
                <div className="auth-form-wrapper">

                    <div className="auth-form-title">Login</div>

                    <form className="auth-form" onSubmit={onSubmit}>

                        <label htmlFor="email">Email:</label>
                        <input id="email" type="text"
                            onChange={(e) => setEmail(e.target.value)}
                            value={email} />

                        <label htmlFor="password">Password:</label>
                        <input id="password" type="password"
                            onChange={(e) => setPassword(e.target.value)}
                            value={password} />

                        <button className="btn btn-main">submit</button>
                    </form>
                </div>
            </div>
        </section>
    );
};

export default LoginPage;