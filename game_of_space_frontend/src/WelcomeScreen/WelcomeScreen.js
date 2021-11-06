import "./WelcomeScreen.css";
import WelcomeScreenFooter from "./WelcomeScreenFooter";

const WelcomeScreen = () => {
    return (
        <div className="WelcomeScreen">
            <div className="WelcomeScreenTitle">
                The Game Of Space
            </div>
            <div className="WelcomeScreenPlayLink">
            <a className="PlayLink" href="/game"> START </a>
            </div>
            <img className="WelcomePageBackground" src={process.env.PUBLIC_URL + '/landscape1.jpg'} alt="background image" />
            
            <WelcomeScreenFooter/>
        
        </div>
    );
}

export default WelcomeScreen;