import './App.css';


function EvenNumbers()
{
  var arr = [];
  for (let i = 0; i < 100; i++) {
    if((i+1)%2==0)
    {
      arr.push(i+1);
    }
  }
  return(
    <div>
      {arr.map(num=><h2>{num}</h2>)};
    </div>
  )
}

function App() {
  return (
    <div className="App">
      <EvenNumbers></EvenNumbers>
      
    </div>
  );
}

export default App;
