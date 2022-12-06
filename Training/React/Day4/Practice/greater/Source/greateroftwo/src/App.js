import React, { useState } from 'react';
import './App.css';

function App() {
  const [num1, setNum1] = useState();
  const [num2, setNum2] = useState();
  const [result, setResult] = useState();
  function check() {
    if (num1 > num2) {
      setResult(`${num1} is Greater.`);
    }
    else if (num1 < num2) {
      setResult(`${num2} is Greater.`);
    }
    else {
      setResult(`Both are Equal`);
    }
  }
  return (
    <div className="App">
      <div class="container">
        <div class="row">
          <div class="col-4 mx-auto my-5">
            <input type="number" class="form-control" onChange={(e) => { setNum1(parseInt(e.target.value)) }} placeholder="Enter Number 1 here" /><br/>
            <input type="number" class="form-control" onChange={(e) => { setNum2(parseInt(e.target.value)) }} placeholder="Enter Number 2 here" /><br/>
            <button class="btn btn-primary" onClick={check}>Check</button><br/>
            <p>{result}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
