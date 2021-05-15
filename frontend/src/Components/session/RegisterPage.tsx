import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { clearSessionErrors, register } from "../../Actions/SessionActions";
import { ISessionErrors } from "../../Models/SessionModel";
import { AppState } from "../../store";
import ErrorList from "../errors/ErrorList";
import DemoLoginButton from "./DemoLoginButton";
import DemoLoginList from "./DemoLoginList";

const RegisterPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const { errors, loading } = useSelector((s: AppState) => {
        return {
            errors: s.session.errors,
            loading: s.session.loading
        };
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

                    {errors && errors.general ? <ErrorList errors={errors.general}/> : "" }

                    <form className="auth-form" onSubmit={onSubmit}>
                        <label htmlFor="email">Email:</label>
                        {errors && errors.email ? <ErrorList errors={errors.email}/> : "" }
                        <input type="text" id="email"
                            value={email}
                            onChange={(e) => { setEmail(e.target.value) }} />

                        <label htmlFor="username">User name:</label>
                        {errors && errors.username ? <ErrorList errors={errors.username}/> : "" }
                        <input type="text" id="username"
                            value={username}
                            onChange={(e) => { setUsername(e.target.value) }} />

                        
                        <label htmlFor="password">Password:</label>
                        {errors && errors.password ? <ErrorList errors={errors.password}/> : "" }
                        <input type="password" id="password"
                            value={password}
                            onChange={(e) => { setPassword(e.target.value) }} />

                        <button className="btn btn-main" disabled={loading}>
                            { loading ? "loading..." : "submit" }
                        </button>
                    </form>

                    <DemoLoginList loading={ loading }/>
                </div>
            </div>
        </section>
    );
};

export default RegisterPage;