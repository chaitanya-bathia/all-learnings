import React, {useState} from 'react';
import './App.css';

function Display(props)
{
  return(
    <h1>{props.demo}</h1>
  )
}

function App() {
  const [name, setName] = useState();
  return (
    <div className="App">
      <input type="text" onChange={(e)=>setName(e.target.value)}></input>

      <Display demo={name}></Display>
    </div>
  );
}

export default App;
