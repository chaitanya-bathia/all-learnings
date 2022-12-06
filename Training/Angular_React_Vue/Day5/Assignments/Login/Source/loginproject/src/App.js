import React, {useState} from 'react';
import './App.css';

function Rectangle()
{
  const [length, setLength] = useState();
  const [width, setWidth] = useState();
  const [area, setArea] = useState();
  const findArea=()=>{ setArea(length*width)};
  return(
    <div class="container-fluid">
      <h1 class="bg-primary text-white">Rectangle Area</h1>
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <label for="txtLength">Length</label>
          <input type="number" onChange={(e)=>setLength(parseInt(e.target.value))} id="txtLength" placeholder="Enter Length" class="form-control" />
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <label for="txtWidth">Width</label>
          <input type="number" onChange={(e)=>setWidth(parseInt(e.target.value))} id="txtWidth" placeholder="Enter Width" class="form-control" />
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <button class="btn btn-primary" onClick={findArea}>Find Area</button>
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto text-center">
          <h3>Area of Given Rectangle is: {area}</h3>
        </div>
      </div>
    </div>
  )
}

function Login()
{
  const [username, setUsername] = useState();
  const [password, setPassword] = useState();

  const[result,setResult] = useState();
  const validate = () => {if(username==="admin" && password==="admin")
  {
    setResult("Login Successful.");
  }
  else
  {
    setResult("Invalid Login Credentials");
  }
}
  return(
    <div class="container-fluid">
      <h1 className='text-center bg-dark text-white'>Login</h1>
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <input type="text" class="form-control" onChange={(e)=> setUsername(e.target.value)} placeholder="Enter Username Here" />
        </div>
      </div>
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <input type="password" class="form-control" onChange={(e)=> setPassword(e.target.value)} placeholder="Enter Password Here" />
        </div>
      </div>
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <button class="btn btn-warning" onClick={validate}>Login</button>
        </div>
      </div>
      <h3>{result}</h3>
    </div>
  )
}

function SignUp()
{
  const [name,setName] = useState();
  const [address,setAddress] = useState();
  const [panNumber,setPanNumber] = useState();
  const[result,setResult] = useState();

  const submit=()=>{
    setResult(`${name}, ${address}, ${panNumber}`);
  }
  return(
    <div class="container-fluid my-4">
      <h1 className='text-center bg-dark text-white'>Sign Up</h1>
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <input type="text" class="form-control" onChange={(e)=> setName(e.target.value)} placeholder="Enter Name Here" />
        </div>
      </div>
      
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <input type="text" class="form-control" onChange={(e)=> setAddress(e.target.value)} placeholder="Enter Address Here" />
        </div>
      </div>
      
      <div class="row">
        <div class="col-4 mx-auto my-3">
          <input type="text" class="form-control" onChange={(e)=> setPanNumber(e.target.value)} placeholder="Enter PAN Number Here" />
        </div>
      </div>

      <div class="row">
        <div class="col-4 mx-auto my-3">
          <button class="btn btn-warning" onClick={submit}>Submit</button>
        </div>
      </div>
      <h5>{result}</h5>
    </div>
  )
}


function App() {
  return (
    <div className="App">
      <Login></Login>
      <SignUp></SignUp>
      <Rectangle></Rectangle>
    </div>
  );
}

export default App;
