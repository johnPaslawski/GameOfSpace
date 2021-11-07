import PlanetLeftPanel from './PlanetLeftPanel';
import PlanetTopPanel from './PlanetTopPanel';

const Planet = ({ fetchedUser }) => {
    return ( <div>
            <PlanetTopPanel fetchedUser={ fetchedUser }/>
            <PlanetLeftPanel fetchedUser={ fetchedUser }/>
            

    </div> );
}
 
export default Planet;