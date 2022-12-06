import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'InternalExam1';

  personArray:Array<any>=[];
  
  PersonForm:FormGroup;
  constructor(private fb: FormBuilder)
  {
    this.PersonForm=this.fb.group({
      name:["",Validators.required],
      email:["",Validators.required],
      gender:["",Validators.required],
      dateOfBirth:["",[Validators.required]],
      skills:[this.fb.array([this.fb.control("")]),Validators.required]
    })
  }

  addSkill()
  {
    this.PersonForm.value.skills.push(this.fb.control(''));
    console.log(this.PersonForm.value.skills.length)
  }

  submitData()
  {
    this.personArray.push(this.PersonForm.value);
    console.log(this.personArray);
  }
}
