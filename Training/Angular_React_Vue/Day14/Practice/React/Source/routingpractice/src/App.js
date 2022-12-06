import { Link,Outlet } from 'react-router-dom';

import './App.css';


function App() {
  return (
    <div className="App">
      <h1>Heading.</h1>

      <div>
        <Link to="/about">About</Link> | {" "}
        <Link to="/contact">Contact</Link>
      </div>
      <Outlet/>
    </div>
    
  );
}

export default App;
