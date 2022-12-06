import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'InternalExam2';

  studentData:Array<any>=[];

  sendData(data:any)
  {
    this.studentData=data;
    console.log(this.studentData);
  }
}
