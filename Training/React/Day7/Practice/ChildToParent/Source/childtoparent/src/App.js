import React,{useState} from 'react';
import './App.css';

function Profile(props)
{
  const [name,setName]=useState();
  function display()
  {
    props.getData(name);
    console.log(name);
  }
  return(
    <div className="container-fluid">
      <h1 className="bg-dark text-white text-center">Profile</h1>
      <div className="row">
        <div className="col-4 mx-auto my-4">
          <input type="text" className="form-control" placeholder="Enter Name" onChange={(e)=>setName(e.target.value)}/>
          <button className="btn btn-success" onClick={display}>Submit</button>
        </div>
      </div>
    </div>
  )
}

function App() {

  const [username,setUsername] = useState("")

  function display(username)
  {
    setUsername(username);
  }
  return (
    <div className="App">
      <Profile getData = {display}></Profile>
      <p>{username}</p>
    </div>
  );
  
}

export default App;
