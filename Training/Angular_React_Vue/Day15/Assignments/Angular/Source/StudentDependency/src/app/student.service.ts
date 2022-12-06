import { Injectable } from '@angular/core';
import { LoggerService } from './logger.service';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  StudentList:any=[];
  constructor(private logger:LoggerService) { }

  addData(obj:any)
  {
    this.StudentList.push(obj);
    this.logger.display(this.StudentList);
  }

  removeData()
  {
    this.StudentList.pop();
    console.log("Data Removed.");
    this.logger.display(this.StudentList);
  }
}
