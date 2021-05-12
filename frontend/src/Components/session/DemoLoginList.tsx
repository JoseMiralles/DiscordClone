import React from "react";
import DemoLoginButton from "./DemoLoginButton";
import "./DemoLoginList.scss";

interface Props {
    loading: boolean;
}

const _DemoLoginList = ({ loading }: Props) => {
    const numberOfUsers = 3;
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
            <div id="demo-login-list-title-wrapper">
            <div id="demo-login-list-title">Or Use A Demo Account</div>
            </div>
            <div id="demo-login-list">
                {mappedButtons}
            </div>
        </section>
    );
}

const DemoLoginList = React.memo(_DemoLoginList);

export default DemoLoginList;