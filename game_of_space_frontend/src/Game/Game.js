import { useParams } from "react-router";
import useApiGet from "../useApiGet";
import Board from "./Board";

const Game = () => {

    const id = 1;
    const url = `https://localhost:44321/api/APITestMethods/getUser/${ id }`;
    const { data, isLoading, error } = useApiGet(url) 
    
    return (
        <div>
            { error && <h3>{ error }</h3> }
            { isLoading && <h2>LOADING . . . </h2> }
            {/* { isLoading && <div className="text-center"><div className="loading spinner-border"></div></div> } */}

            { data && <Board fetchedUser={ data }/> }
        </div>
    );
}
 
export default Game;