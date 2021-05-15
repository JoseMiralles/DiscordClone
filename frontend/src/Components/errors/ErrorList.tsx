import { ISessionErrors } from "../../Models/SessionModel";
import "./ErrorList.scss";

interface Props {
    errors: string[];
}

const ErrorList = ({ errors }: Props) => {
    const mappederrors: JSX.Element[] = errors.map((err, i) => <li key={i}>{err}</li>);

    return (
        <div className="errors-list">
            <ul>
                {mappederrors}
            </ul>
        </div>
    );
};

export default ErrorList;