import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})

export class EmployeeComponent implements OnInit {

  constructor() { }

  empID=0;
  empName='';
  empAddress='';
  empGender='';
  empDOJ='';
  empHobby='';

  filterval=false;
  

  arrEmployee :Array<Employee> = []

  arrHobby:Array<string>=[]

  

  filteredArray : Array<Employee>=[]
  filter()
  {
    this.filterval=true;
    this.arrEmployee.forEach(element => {
      console.log(new Date().getMonth());
      if(parseInt(element.employeeDOJ.split("-")[1]) == new Date().getMonth()+1)
      {
        this.filteredArray.push(element);
      }
    });
  }


  submit()
  {
    this.filterval=false;
    if(this.empID==0||this.empName==''||this.empAddress==''||this.empGender==''||this.empDOJ==''||this.empHobby=='')
    {
      alert("One or more fields are EMPTY. Please fill them and try again.");
    }
    else
    {
      this.arrEmployee.push(new Employee(this.empID,this.empName,this.empAddress,this.empGender,this.empDOJ,this.empHobby));
      this.arrEmployee.sort((a, b) => a.employeeName.localeCompare(b.employeeName))
      this.empID=0;
      this.empName='';
      this.empAddress='';
      this.empGender='';
      this.empDOJ='';
      this.empHobby='';

      
    }
  }

  ngOnInit(): void {
  }

}

class Employee
{
  employeeID: number;
  employeeName:string;
  employeeAddress:string;
  employeeGender:string;
  employeeDOJ:string;
  employeeHobbies:string;

  constructor(employeeID:number,employeeName:string,employeeAddress:string,employeeGender:string,employeeDOJ:string,employeeHobbies:string)
  {
    this.employeeID=employeeID;
    this.employeeName=employeeName;
    this.employeeAddress=employeeAddress;
    this.employeeGender=employeeGender;
    this.employeeDOJ=employeeDOJ;
    this.employeeHobbies=employeeHobbies;

  }
}
