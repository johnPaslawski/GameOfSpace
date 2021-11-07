import { useState } from "react";
import Planet from "./Planet";

const PlanetLeftPanel = ({ fetchedUser }) => {

    const [user, setUser] = useState(fetchedUser)

    return (
        <div className="LeftPanel">
            <div className="LeftPanelGameLogo">

                <div>TGoS v.1.0</div>
            </div>
            
            <div className="LeftPanelTitleLogo">
                <img className="gameIcon" src={process.env.PUBLIC_URL + '/gameIcon.jpg'} alt="icon image" />
            </div>
            <div className="LeftPanelTitleLogo"><img className="gameFadedIcon" src={process.env.PUBLIC_URL + '/gameIcon.jpg'} alt="icon image" /></div>

            <div className="LeftPanelTitleElement">
                <div className="LeftPanelTitleSubElement">
                    <img className="planetImage" src={process.env.PUBLIC_URL + '/planets/planet1.jpg'} alt="icon image" />
                </div>
                <div className="LeftPanelTitleSubElement">
                    Planet: <div className="planetName">{user.planetarySystems[0].planets[5].name}</div>
                </div>
                <div className="LeftPanelTitleSubElement">
                    Temperature amplitude: min: <span className="blue">{user.planetarySystems[0].planets[5].minTemp} °C</span> {" <=> "} {"  "}  max: <span className="red">{user.planetarySystems[0].planets[5].maxTemp} °C</span>
                </div>
                <div className="LeftPanelTitleSubElement">
                    Population [estimated]: {user.planetarySystems[0].planets[5].population}
                </div>
                <div className="LeftPanelTitleSubElement">
                    Planetary System: {user.planetarySystems[0].name}
                </div>

            </div>
            <div className="LeftPanelElement">Buildings</div>
            <div className="LeftPanelElement">War Fleet</div>
            <div className="LeftPanelElement">Planet Defense system</div>
            <div className="LeftPanelElement">Logistics</div>
        </div>
    );
}

export default PlanetLeftPanel;