import { useState } from "react";

const PlanetTopPanel = ({ fetchedUser }) => {

    const [user, setUser] = useState(fetchedUser)
console.log(user);

    return (
        <div className="TopPanel">
            <div className="TopPanelElement">
                { "{planetId}" } Resources:
            </div>
            <div className="TopPanelElement">
                element
            </div>
            <div className="TopPanelElement">
                element
            </div>
            <div className="TopPanelElement">
                element
            </div>
            <div className="userName">
               <div className="loggedUser">user: {user.userName}</div>
            </div>
        </div>
    );
}

export default PlanetTopPanel;