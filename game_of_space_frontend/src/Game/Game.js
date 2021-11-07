import { useParams } from "react-router";
import useApiGet from "../useApiGet";
import HUD from "./HUD/HUD";
import WelcomeScreenFooter from "../WelcomeScreen/WelcomeScreenFooter";

const Game = () => {

    const id = 1;
    const url = `https://localhost:44321/api/APITestMethods/getUser/${ id }`;
    const { data, isLoading, error } = useApiGet(url) 
    
    return (
        <div className="Game">
        <img className="WelcomePageBackground" src={process.env.PUBLIC_URL + '/landscape2.jpg'} alt="background image" />

            { error && <div>{ error }</div> }
            { isLoading && <div>LOADING . . . </div> }
            {/* { isLoading && <div className="text-center"><div className="loading spinner-border"></div></div> } */}

            { data && <HUD fetchedUser={ data }/> }
            <WelcomeScreenFooter />
        </div>
    );
}
 
export default Game;