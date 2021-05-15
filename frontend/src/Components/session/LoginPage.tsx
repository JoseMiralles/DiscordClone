import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import "./AuthPage.scss";
import { clearSessionErrors, login } from "../../Actions/SessionActions";
import DemoLoginButton from "./DemoLoginButton";
import { AppState } from "../../store";
import ErrorList from "../errors/ErrorList";
import DemoLoginList from "./DemoLoginList";

const LoginPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
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
            dispatch(await login({
                email, password
            }));
        };
        act();
    };

    useEffect(() => {
        // Cleanup function, "ComponentWillUnmount"
        return () => {
            dispatch(clearSessionErrors());
        }
    }, []);

    return (
        <section className="auth-form-section">
            <div className="container">
                <div className="auth-form-wrapper">

                    <div className="auth-form-title">Login</div>

                    {errors && errors.general ? <ErrorList errors={errors.general}/> : "" }

                    <form className="auth-form" onSubmit={onSubmit}>

                        <label htmlFor="email">Email:</label>
                        {errors && errors.email ? <ErrorList errors={errors.email}/> : "" }
                        <input id="email" type="text"
                            onChange={(e) => setEmail(e.target.value)}
                            value={email} />

                        <label htmlFor="password">Password:</label>
                        {errors && errors.password ? <ErrorList errors={errors.password}/> : "" }
                        <input id="password" type="password"
                            onChange={(e) => setPassword(e.target.value)}
                            value={password} />

                        <button disabled = {loading ? true : false}
                            className="btn btn-main">{!loading ? "submit" : "submitting..."}</button>
                    </form>
                    
                    <DemoLoginList loading={ loading }/>
                </div>
            </div>
        </section>
    );
};

export default LoginPage;