import JSONPretty from 'react-json-pretty';
import './Game.css'
const Board = ({ fetchedUser }) => {
    return (
        <div>
        <div className="prettyJson">
           JSON User:
           <JSONPretty id="json-pretty" data= { fetchedUser } />
           
        </div>
        <img className="WelcomePageBackground" src={process.env.PUBLIC_URL + '/landscape2.jpg'} alt="background image" />
        </div>
        
    );
}
 
export default Board;