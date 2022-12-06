import React, {useState} from 'react';
import './App.css';


function FormComponent()
{
  const [userName,setUserName] = useState("");
  const [gender,setGender] = useState("");
  const [hobbies,addHobby] = useState("");
  const [city, setCity]= useState("");
  const [arrUser,pushIntoArr] = useState([]);


  function submit(e)
  {
    e.preventDefault();
    let objUser = {userName,gender};
    objUser.userName=userName;
    objUser.gender=gender;
    objUser.hobbies = hobbies;
    
    pushIntoArr(()=>[...arrUser,objUser]);

    console.log(arrUser);
    setUserName("");
    setGender("");
  }
  return(
    <div className='container-fluid'>
      <div className='row'>
        <div className='col bg-warning'>
          <h1>Form</h1>
        </div>
      </div>
      <div className='row my-4'>
        <div className='col-4 mx-auto'>
          <form onSubmit={submit}>
              <input type="text" className='form-control' placeholder='Username Here.' value={userName} onChange={(e)=> setUserName(e.target.value)} /><br/>
              <label>Gender:</label><br/>
              <input type="radio" id='genderMale' name="gender" value="Male" onChange={(e)=>setGender(e.target.value)}/><label >Male</label><br/>
              <input type="radio" id='genderFemale' name="gender" value="Female" onChange={(e)=>setGender(e.target.value)}/><label >Female</label><br/><br/>

              <label>Hobbies: </label><br/>
              <input type="text"  onChange={(e)=>addHobby(e.target.value)} /><br/><br/>

              <label>City: </label>
              <select onChange={(e)=>setCity(e.target.value)}>
                <option>Ahmedabad</option>
                <option>Jamnagar</option>
                <option>Rajkot</option>
                <option>Surat</option>
              </select><br/>
              <button type='submit' className='btn btn-warning'>Submit</button>
              <p>{city}</p>
          </form>
        </div>
      </div>
    </div>
  )
}

function App() {
  return (
    <div className="App">
      <FormComponent></FormComponent>
    </div>
  );
}

export default App;
