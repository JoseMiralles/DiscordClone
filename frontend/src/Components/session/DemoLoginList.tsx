import DemoLoginButton from "./DemoLoginButton";
import "./DemoLoginList.scss";

interface Props {
    loading: boolean;
}

const DemoLoginList = ({ loading }: Props) => {
    const numberOfUsers = 4;
    const mappedButtons: JSX.Element[] = [];

    let userNum: number;
    for (let i = 0; i < numberOfUsers; i++) {
        userNum = i + 1;
        mappedButtons[i] = (
            <DemoLoginButton
                key={userNum}
                loading={loading}
                userNumber={userNum}>
                
                {`user ${userNum}`}

            </DemoLoginButton>
        );
    }

    return (
        <section id="demo-login-list-section">
            <div id="demo-login-list-title">Use demo account:</div>
            <div id="demo-login-list">
                {mappedButtons}
            </div>
        </section>
    );
}

export default DemoLoginList;