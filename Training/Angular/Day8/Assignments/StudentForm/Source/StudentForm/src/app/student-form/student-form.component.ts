import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-student-form',
  templateUrl: './student-form.component.html',
  styleUrls: ['./student-form.component.css']
})
export class StudentFormComponent implements OnInit {


  arrStudent:Array<any>=[]

  studentForm !: FormGroup;

  constructor(private formbuilder: FormBuilder) {
    this.studentForm = this.formbuilder.group({
      name: this.formbuilder.group({
        firstName: ["",Validators.required],
        middleName: ["",Validators.required],
        lastName: ["",Validators.required]
      }),
      dob: ["",Validators.required],
      placeOfBirth: ["",Validators.required],
      firstLanguage: ["",Validators.required],
      address: this.formbuilder.group({
        city: ["",Validators.required],
        state: ["",Validators.required],
        country: ["",Validators.required],
        pin: [111111,Validators.required]
      }),
      father: this.formbuilder.group({
        name: this.formbuilder.group({
          firstName: ["",Validators.required],
          middleName: ["",Validators.required],
          lastName: ["",Validators.required]
        }),
        email: ["",Validators.required],
        educationQualification: ["",Validators.required],
        profession: ["",Validators.required],
        designation: ["",Validators.required],
        phoneNumber: ["",Validators.required]
      }),
      mother: this.formbuilder.group({
        name: this.formbuilder.group({
          firstName: ["",Validators.required],
          middleName: ["",Validators.required],
          lastName: ["",Validators.required]
        }),
        email: ["",Validators.required],
        educationQualification: ["",Validators.required],
        profession: ["",Validators.required],
        designation: ["",Validators.required],
        phoneNumber: ["",Validators.required]
      }),
      emergencyContactList: this.formbuilder.array([
        {
          relation: ["Test",Validators.required],
          number: ["123456789",Validators.required]
        }
      ]),
      reference: this.formbuilder.group({
        referenceDetails: ["",Validators.required],
        referenceThrough: ["",Validators.required],
        address:this.formbuilder.group({
          city:["",Validators.required],
          state:["",Validators.required],
          country:["",Validators.required],
          pin:[111111,Validators.required]
        }),
        phoneNumber:["",Validators.required]
      })

    })
  }


  ngOnInit(): void {
  }


  get getEmergencyContactsList()
  {
    return this.studentForm.get("emergencyContactList") as FormArray;
  }

  submit()
  {
    console.log(this.studentForm.value);
    this.arrStudent.push(this.studentForm.value);
    console.log(this.arrStudent);
    this.studentForm.reset();
  }
}

