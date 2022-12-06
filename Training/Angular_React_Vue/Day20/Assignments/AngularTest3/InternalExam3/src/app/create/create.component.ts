import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  student={name:"",address:"",panNumber:"",phoneNumber:""}

  studentArray:Array<any>=[];

  @Output() getListEvent = new EventEmitter();
  save()
  {
    let tempStudent = this.student;
    if(this.validate(tempStudent))
    {
      this.studentArray.push(tempStudent);
      console.log(this.studentArray);
      this.getListEvent.emit(this.studentArray);
    }
    else{
      alert("phone number is not 10 digits");
    }
  }

  validate(tempStudent:any)
  {
    if(tempStudent.phoneNumber.length<10 || tempStudent.phoneNumber.length>10)
    {
      return false;
    }
    return true;
  }
  
  
}
