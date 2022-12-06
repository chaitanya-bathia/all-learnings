import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  

  StudentObject={studentID:0,studentName:"",studentAddress:""}
  constructor(private studentService: StudentService) { }

  ngOnInit(): void {
  }

  addData()
  {
    if(this.StudentObject.studentID===0 || this.StudentObject.studentName===""|| this.StudentObject.studentAddress==="")
    {
      alert("Field cannot be empty.")
    }
    else
    {
      let tempObj = this.StudentObject
      this.studentService.addData(tempObj);
    }
  }

  removeLast()
  {
    this.studentService.removeData();
  }


}
