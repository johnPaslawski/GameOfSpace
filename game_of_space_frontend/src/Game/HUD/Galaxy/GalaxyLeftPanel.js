import { useState } from "react";
import HUD from "../HUD";
import './Galaxy.css';

const GalaxyLeftPanel = ({ fetchedUser }) => {

    const [user, setUser] = useState(fetchedUser);

    return (
        <div className="LeftPanel">
            {/* Game LOGO ------------------- */}
            <div className="LeftPanelGameLogo">
                <div>TGoS v.1.0</div>
            </div>
            <div className="LeftPanelTitleLogo"><
                img className="gameIcon" src={process.env.PUBLIC_URL + '/gameIcon.jpg'} alt="icon image" />
            </div>
            <div className="LeftPanelTitleLogo"><img className="gameFadedIcon" src={process.env.PUBLIC_URL + '/gameIcon.jpg'} alt="icon image" /></div>

            {/* END OF LOGO ------------------- */}
            <div className="LeftPanelTitleElement">
                <div className="LeftPanelTitleSubElement">
                    <img className="galaxyImage" src={process.env.PUBLIC_URL + '/galaxies/NGC 5457.jfif'} alt="icon image" />
                </div>
                <div className="LeftPanelTitleSubElement">
                    Galaxy: <div className="planetName">{user.planetarySystems[0].galaxy.name}</div>
                </div>
                <div className="LeftPanelTitleSubElement">
                    Diameter:<div className="blue">{user.planetarySystems[0].galaxy.diameter}</div> 
                </div>
                

            </div>
            <div className="LeftPanelElement">elem1</div>
            <div className="LeftPanelElement">elem2</div>
        </div>
    );
}

export default GalaxyLeftPanel