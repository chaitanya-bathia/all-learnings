import React,{useState} from 'react';
import './App.css';


function Calc() {
  const [num1,setNum1] = useState();
  const [num2,setNum2] = useState();
  const [result,setResult] = useState();

  const sum=()=>{setResult(num1+num2)};
  const subtract=()=>{setResult(num1-num2)};
  const product=()=>{setResult(num1*num2)};
  return (
    <div class="container">
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <label for="txtNum1">Number 1:</label>
          <input type="number" onChange={(e)=>setNum1(parseInt(e.target.value))} id="txtNum1" placeholder="Enter Num1" class="form-control" />
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <label for="txtNum2">Number 2:</label>
          <input type="number" onChange={(e)=>setNum2(parseInt(e.target.value))} id="txtNum2" placeholder="Enter Num2" class="form-control" />
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto">
          <button class="btn btn-primary" onClick={sum}>+</button>
          <button class="btn btn-warning" onClick={subtract}>-</button>
          <button class="btn btn-danger" onClick={product}>*</button>
        </div>
      </div>
      <div class="row my-3">
        <div class="col-4 mx-auto text-center">
          <h2>{result}</h2>
        </div>
      </div>
    </div>
  )
}

function App() {
  return (
    <div className="App">
      <Calc></Calc>
    </div>
  );
}

export default App;
