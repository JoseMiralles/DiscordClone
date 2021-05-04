import { useState } from "react";
import { useDispatch } from "react-redux";
import { register } from "../../Actions/SessionActions";

const RegisterPage = () => {

    const dispatch = useDispatch();

    const [email, setEmail] = useState("");
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");

    const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        dispatch(register({
            email, username, password
        }));
    };

    return (
        <section>
            <div>
                <form onSubmit={onSubmit}>
                    <label htmlFor="email">Email:</label>
                    <input type="text" id="email"
                        value={email}
                        onChange={(e) => { setEmail(e.target.value) }} />
                    
                    <label htmlFor="username">User name:</label>
                    <input type="text" id="username"
                        value={username}
                        onChange={(e) => { setUsername(e.target.value) }} />
                    
                    <label htmlFor="password">Password:</label>
                    <input type="text" id="password"
                        value={password}
                        onChange={(e) => { setPassword(e.target.value) }} />
                    
                    <button>register</button>
                </form>
            </div>
        </section>
    );
};

export default RegisterPage;