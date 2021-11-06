import './App.css';
import WelcomeScreen from './WelcomeScreen/WelcomeScreen';
import Game from './Game/Game';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';

function App() {
  return (
    <Router>
      <div className="App">
        <Switch>
          <Route exact path="/">
            <WelcomeScreen />
          </Route>
          <Route path="/game">
            <Game />
          </Route>
        </Switch>
      </div>
    </Router>

  );
}

export default App;
