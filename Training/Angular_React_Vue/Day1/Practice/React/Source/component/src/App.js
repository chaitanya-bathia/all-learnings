import logo from './logo.svg';
import './App.css';
var name = "Chaitanya Bathia";
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Hello World from React</h1>
        <p>
          Good day to you, {name}!
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
