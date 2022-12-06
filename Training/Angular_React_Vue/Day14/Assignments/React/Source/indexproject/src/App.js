import {Link,Outlet } from 'react-router-dom';
import './App.css';

function App() {
  return (
    <div className="App">
      <div className="container-fluid">
        <div className="row">
          <div className="p-2 bg-dark col d-flex justify-content-evenly">
            <Link to="/html" className='btn btn-warning'>HTML</Link>
            <Link to="/css" className='btn btn-warning'>CSS</Link>
            <Link to="/js" className='btn btn-warning'>JavaScript</Link>
          </div>
        </div>
        <div className='row'>
          <Outlet></Outlet>
        </div>
      </div>
    </div>
  );
}

export default App;
