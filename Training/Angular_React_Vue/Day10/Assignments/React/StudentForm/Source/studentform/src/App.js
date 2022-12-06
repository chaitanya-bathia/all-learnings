import React, {useState} from 'react';
import './App.css';

function StudentForm()
{
  const [studentName,setStudentName] = useState("");
  const [gender,setGender] = useState("");
  const [hobbies,addHobby] = useState("");
  const [city, setCity]= useState("");
  const [state, setState] = useState("");
  const [arrStudent,pushIntoArr] = useState([]);

  function submit(e)
  {
    e.preventDefault();
    let objStudent = {studentName,gender,hobbies,city,state};
    if(studentName==="" || gender===""|| hobbies==="" || city===""|| state===""||city==="Select City" || state==="Select State")
    {
      alert("One or More Fields are empty. Try Again");
      return;
    }
    else
    {
      objStudent.studentName=studentName;
      objStudent.gender=gender;
      objStudent.hobbies = hobbies;
      objStudent.city=city;
      objStudent.state=state;
    }
    
    pushIntoArr(()=>[...arrStudent,objStudent]);

    console.log(arrStudent);
    
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
              <input type="text" className='form-control' placeholder='Student Name Here.' value={studentName} onChange={(e)=> setStudentName(e.target.value)} /><br/>
              <label>Gender:</label><br/>
              <input type="radio" id='genderMale' name="gender" value="Male" onChange={(e)=>setGender(e.target.value)}/><label >Male</label><br/>
              <input type="radio" id='genderFemale' name="gender" value="Female" onChange={(e)=>setGender(e.target.value)}/><label >Female</label><br/><br/>

              <label>Hobbies: </label><br/>
              <input className='form-control' type="text"  onChange={(e)=>addHobby(e.target.value)} /><br/><br/>

              <label>City: </label>
              <select className='form-control' onChange={(e)=>setCity(e.target.value)}>
                <option>Select City</option>
                <option>Ahmedabad</option>
                <option>Jamnagar</option>
                <option>Rajkot</option>
                <option>Surat</option>
              </select><br/>

              <label>State: </label>
              <select className='form-control' onChange={(e)=>setState(e.target.value)}>
                <option>Select State</option>
                <option>Gujarat</option>
                <option>Rajasthan</option>
                <option>Delhi</option>
                <option>Maharashtra</option>
              </select><br/>
              <button type='submit' className='btn btn-warning'>Submit</button>
          </form>
        </div>
      </div>
      <div className='row'>
        <h1 className='bg-dark text-white'>Student Data Table</h1>
        <div className='col my-5'>
          <table  className='table table-striped table-hover'>
            <thead>
              <tr>
              <th>Student Name</th>
              <th>Gender</th>
              <th>Hobbies</th>
              <th>City</th>
              <th>State</th>
              </tr>
            </thead>
            <tbody>
              {
                arrStudent.map((student)=>{
                  return(
                    <tr key={student.studentName}>
                      <td>{student.studentName}</td>
                      <td>{student.gender}</td>
                      <td>{student.hobbies}</td>
                      <td>{student.city}</td>
                      <td>{student.state}</td>
                    </tr>
                  )
                })
              }
            </tbody>
          </table>
        </div>
      </div>
    </div>
  )
}

function App() {
  return (
    <div className="App">
      <StudentForm></StudentForm>
    </div>
  );
}

export default App;
