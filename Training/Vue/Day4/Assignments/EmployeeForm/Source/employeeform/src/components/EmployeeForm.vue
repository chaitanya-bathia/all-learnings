<template>
  <div>
    <div class="container-fluid">
      <div class="row">
        <div class="col bg-dark text-white text-center">
          <h2>Employee Form</h2>
        </div>
      </div>
      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empID">Employee ID</label>
        </div>
        <div class="col-4 my-2">
          <input
            type="number"
            id="empID"
            class="form-control"
            placeholder="Employee ID here."
            v-model="empID"
          />
        </div>
      </div>

      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empName">Employee Name</label>
        </div>
        <div class="col-4 my-2">
          <input
            type="text"
            id="empName"
            class="form-control"
            placeholder="Employee Name here."
            v-model="empName"
          />
        </div>
      </div>

      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empAddress">Employee Address</label>
        </div>
        <div class="col-4 my-2">
          <textarea
            id="empAddress"
            class="form-control"
            placeholder="Employee Address here."
            v-model="empAddress"
          ></textarea>
        </div>
      </div>

      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empGender">Gender</label>
        </div>
        <div class="col-4 my-2 text-justify">
          <input
            type="radio"
            name="gender"
            id="genMale"
            value="Male"
            v-model="empGender"
          />
          <label for="genMale">Male</label><br />

          <input
            type="radio"
            name="gender"
            id="genFemale"
            value="Female"
            v-model="empGender"
          />
          <label for="genFemale">Female</label><br />

          <input
            type="radio"
            name="gender"
            id="genOther"
            value="Others"
            v-model="empGender"
          />
          <label for="genOther">Others</label>
          <br />
        </div>
      </div>

      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empDOJ">Date of Joining</label>
        </div>
        <div class="col-4 my-2">
          <input
            type="date"
            id="empDOJ"
            class="form-control"
            placeholder="Joining Date here."
            v-model="empDOJ"
          />
        </div>
      </div>

      <div class="row text-center justify-content-center">
        <div class="col-2 my-2">
          <label for="empHobbies">Hobbies</label>
        </div>
        <div class="col-4 my-2">
            <input type="text" id="empHobby" class="form-control" placeholder="Hobbies here." v-model="empHobby">
        </div>
      </div>
      <div class="container">
          <div class="row">
              <div class="col-4 mx-auto">
                  <button class="btn btn-primary" @click="submit">Submit</button>
                  <button class="btn btn-secondary" @click="filter">Filter</button>
                  <p>{{output}}</p>
              </div>
          </div>
      </div>
      <div class="container">
          <div class="row">
              <div class="col">
                  <table class="table table-dark">
                      <caption hidden>Display Table</caption>
                      <thead>
                          <tr>
                              <th>ID</th>
                              <th>Name</th>
                              <th>Address</th>
                              <th>Gender</th>
                              <th>Joining Date</th>
                              <th>Hobbies</th>
                          </tr>
                      </thead>
                      <tbody v-if="filterval==false">
                          <tr v-for="emp in arrEmployee" :key="emp.employeeID">
                              <td>{{emp.employeeID}}</td>
                              <td>{{emp.employeeName}}</td>
                              <td>{{emp.employeeAddress}}</td>
                              <td>{{emp.employeeGender}}</td>
                              <td>{{emp.employeeDOJ}}</td>
                              <td>{{emp.employeeHobbies}}</td>
                          </tr>
                      </tbody>
                      <tbody v-else>
                          <tr v-for="emp in filteredArr" :key="emp.employeeID">
                              <td>{{emp.employeeID}}</td>
                              <td>{{emp.employeeName}}</td>
                              <td>{{emp.employeeAddress}}</td>
                              <td>{{emp.employeeGender}}</td>
                              <td>{{emp.employeeDOJ}}</td>
                              <td>{{emp.employeeHobbies}}</td>
                          </tr>
                      </tbody>
                  </table>
              </div>
          </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "EmployeeForm",
  data() {
    return {
      empID: 0,
      empName: "",
      empAddress: "",
      empGender:'',
      empDOJ:'',
      empHobby:'',
      filterval:false,
      output:'',

    arrEmployee:[],

    filteredArr:[]

    };
  },
  methods:
  {
    submit()
    {
        this.filterval=false
        if(this.empID==0||this.empName==''||this.empAddress==''||this.empGender==''||this.empDOJ==''||this.empHobby=='')
        {
        alert("One or more fields are EMPTY. Please fill them and try again.");
        }
        else
        {
            this.arrEmployee.push(new Employee(this.empID,this.empName,this.empAddress,this.empGender,this.empDOJ,this.empHobby));
            this.output=this.arrEmployee.length;
            this.arrEmployee.sort((a, b) => a.employeeName.localeCompare(b.employeeName))
            this.empID=0;
            this.empName='';
            this.empAddress='';
            this.empGender='';
            this.empDOJ='';
            this.empHobby='';
        }
    },

    filter()
    {
        this.filterval=true;
        this.arrEmployee.forEach(element => {
            if(parseInt(element.employeeDOJ.split("-")[1])==new Date().getMonth()+1)
            {
                this.filteredArr.push(element);
                console.log(element.employeeDOJ.split("-")[1]);
            }
        });
    }
  }
};

class Employee
{
  employeeID;
  employeeName;
  employeeAddress;
  employeeGender;
  employeeDOJ;
  employeeHobbies;

  constructor(employeeID,employeeName,employeeAddress,employeeGender,employeeDOJ,employeeHobbies)
  {
    this.employeeID=employeeID;
    this.employeeName=employeeName;
    this.employeeAddress=employeeAddress;
    this.employeeGender=employeeGender;
    this.employeeDOJ=employeeDOJ;
    this.employeeHobbies=employeeHobbies;

  }
}


</script>