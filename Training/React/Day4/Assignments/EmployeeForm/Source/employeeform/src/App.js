import React, {useState} from 'react';
import './App.css';
import './index.css'

function EmployeeForm()
{
  const [employeeID, setID] = useState(0);
  const [employeeName,setName] = useState("");
  const [employeeAddress,setAddress]=useState("");
  const [employeeGender,setGender] = useState("");
  const [employeeDOJ,setDOJ] = useState();
  const [employeeHobbies,setHobbies] = useState("");

  const [arrEmployees,addEmployee] = useState([]);


  const [arrFiltered,addFilter] = useState([]);
  
  var objFilled = false;


  function Submit(){
    if(employeeID===0||employeeName===""||employeeAddress===""||employeeGender===""||employeeDOJ==="")
    {
      alert("One or more fields are empty. Try Again.");
      objFilled=false;

      
    }
    else
    {
      addEmployee(()=>[...arrEmployees,{employeeID,employeeName,employeeAddress,employeeGender,employeeDOJ,employeeHobbies}])

      objFilled=true;
    }

    if(objFilled===true)
    {
      arrEmployees.sort((a, b) => a.employeeName.localeCompare(b.employeeName));
      console.log(arrEmployees);
    }
  }

  

  function Filter()
  {
    arrEmployees.forEach((emp)=>
    {
      console.log({employeeDOJ});
      if(employeeDOJ.split("-")[1]===(new Date().getMonth()+1).toString())
      {
        addFilter(()=> [...arrFiltered,emp])
      }
    })

    console.log(arrFiltered.length);
  }
  

  return(
    <div className="container-fluid">
      <h1 className="text-center text-white bg-dark">Employee Form</h1>
      <div className="row">
        <div className="col-2 text-center">
          <label>Employee ID:</label>
        </div>
          <div className="col-4 text-center">
          <input className="form-control" type="number" placeholder="Enter ID Here" onChange={(e)=> setID(e.target.value)}/><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-2 text-center">
          <label>Employee Name:</label>
        </div>
        <div className="col-4 text-center">
          <input className="form-control" type="text" placeholder="Enter Name Here" onChange={(e)=> setName(e.target.value)}/><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-2 text-center">
          <label>Address:</label>
        </div>
        <div className="col-4 text-center">
          <input className="form-control" type="text" placeholder="Enter Address Here" onChange={(e)=> setAddress(e.target.value)}/><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-2 text-center">
          <label>Employee Gender:</label>
        </div>
        <div className="col-4 text-center">
          <input  type="radio" name="gender" value="Male" onChange={(e)=> setGender(e.target.value)}/>
          <label>Male</label><br/>

          <input  type="radio" name="gender" value="Female" onChange={(e)=> setGender(e.target.value)}/>
          <label>Female</label><br/>

          <input  type="radio" name="gender" value="Others" onChange={(e)=> setGender(e.target.value)}/>
          <label>Others</label><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-2 text-center">
          <label>Date of Joining:</label>
        </div>
        <div className="col-4 text-center">
          <input className="form-control" type="date" placeholder="Select Date" onChange={(e)=> setDOJ(e.target.value)}/><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-2 text-center">
          <label>Hobbies:</label>
        </div>
        <div className="col-4 text-center">
          <input className="form-control" type="text" placeholder="Enter Hobbies Here" onChange={(e)=> setHobbies(e.target.value)}/><br/>
        </div>
      </div>

      <div className="row">
        <div className="col-4 text-center">
          <button className="btn btn-success" onClick={Submit}>Submit</button>
          <button className="btn btn-warning" onClick={Filter}>Filter</button>
          <p>{employeeName}</p>
        </div>
      </div>

      <div className='row my-4'>
        <h1 className="text-center bg-info">Employee List</h1>
        <div className='col'>
          <table className='table table-striped table-hover'>
            <thead>
              <tr>
                <td>ID</td>
                <td>Name</td>
                <td>Address</td>
                <td>Gender</td>
                <td>Joining Date</td>
                <td>Hobbies</td>
              </tr>
            </thead>
            <tbody>
              {arrEmployees.map((employee) =>{
                return(
                  <tr key={employee.employeeID}>
                    <td>{employee.employeeID}</td>
                    <td>{employee.employeeName}</td>
                    <td>{employee.employeeAddress}</td>
                    <td>{employee.employeeGender}</td>
                    <td>{employee.employeeDOJ}</td>
                    <td>{employee.employeeHobbies}</td>
                  </tr>
                )
              })}
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
      <EmployeeForm></EmployeeForm>
    </div>
  );
}

export default App;
