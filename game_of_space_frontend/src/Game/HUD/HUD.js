import JSONPretty from 'react-json-pretty';
import './HUD.css';
import PlanetarySystem from './PlanetarySystem/PlanetarySystem';
import Galaxy from './Galaxy/Galaxy';
import Planet from './Planet/Planet';
import { Redirect, Route, Switch } from 'react-router';

const HUD = ({ fetchedUser }) => {
    return (
        <div>
            {/* <div className="prettyJson">
                <div className="BoardTitle"> JSON User: </div>
                <JSONPretty id="json-pretty" data={fetchedUser} />
            </div> */}
            <Switch>
                <Route exact path="/game">
                    <Redirect to="/game/planet" />
                    </Route>
                <Route path="/game/galaxy">
                    <Galaxy fetchedUser={fetchedUser}/>
                </Route>
                <Route path="/game/planetarySystem">
                    <PlanetarySystem fetchedUser={fetchedUser}/>
                </Route>
                <Route path="/game/planet">
                    <Planet fetchedUser={fetchedUser} />
                </Route>
            </Switch>


        </div>

    );
}

export default HUD;