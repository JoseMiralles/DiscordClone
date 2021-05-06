import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { clearSessionErrors, register } from "../../Actions/SessionActions";
import { ISessionErrors } from "../../Models/SessionModel";
import { AppState } from "../../store";
import ErrorList from "../errors/ErrorList";
import DemoLoginButton from "./DemoLoginButton";

const RegisterPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    let errors: ISessionErrors = { Email: [], Password: [], Username: [] };
    let loading = false;
    useSelector((s: AppState) => {
        if (s.session.errors != undefined) errors = s.session.errors;
        loading = s.session.loading;
    });

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        const act = async () => {
            dispatch(await register({
                email, username, password
            }));
        };
        act();
    };

    useEffect(() => {
        return function cleanup() {
            dispatch(clearSessionErrors());
        };
    }, []);

    return (
        <section className="auth-form-section">
            <div className="container">
                <div className="auth-form-wrapper">

                    <div className="auth-form-title">Register</div>

                    <form className="auth-form" onSubmit={onSubmit}>
                        <label htmlFor="email">Email:</label>
                        {errors && errors.Email ? <ErrorList errors={errors.Email}/> : "" }
                        <input type="text" id="email"
                            value={email}
                            onChange={(e) => { setEmail(e.target.value) }} />

                        <label htmlFor="username">User name:</label>
                        {errors && errors.Username ? <ErrorList errors={errors.Username}/> : "" }
                        <input type="text" id="username"
                            value={username}
                            onChange={(e) => { setUsername(e.target.value) }} />

                        
                        <label htmlFor="password">Password:</label>
                        {errors && errors.Password ? <ErrorList errors={errors.Password}/> : "" }
                        <input type="password" id="password"
                            value={password}
                            onChange={(e) => { setPassword(e.target.value) }} />

                        <DemoLoginButton userNumber={1}>user 1</DemoLoginButton>

                        <button className="btn btn-main" disabled={loading}>
                            { loading ? "loading..." : "submit" }
                        </button>
                    </form>
                </div>
            </div>
        </section>
    );
};

export default RegisterPage;