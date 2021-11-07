import { useState } from "react";
import GalaxyLeftPanel from "./GalaxyLeftPanel";

const Galaxy = ({ fetchedUser }) => {

const [user, setUser] = useState(fetchedUser);

    return ( <div>
        <GalaxyLeftPanel fetchedUser={ fetchedUser }/>
    </div> );
}
 
export default Galaxy;