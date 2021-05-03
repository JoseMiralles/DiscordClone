import NavBar from "./NavBar"

interface Props {
    isAuthenticated: boolean;
}

const Header = ({ isAuthenticated }: Props) => {

    return (
        <>
            <NavBar isAuthenticated={isAuthenticated}/>
        </>
    );
};

export default Header;