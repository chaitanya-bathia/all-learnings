import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder, FormArray, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.css']
})
export class FormBuilderComponent implements OnInit {


  reactiveForm !:FormGroup;
  constructor(private formbuilder:FormBuilder) {
    this.reactiveForm=this.formbuilder.group({
      name:["", Validators.required],
      address:this.formbuilder.group({
        flatNo:[0],
        area:[""],
        city:[""],
        state:[""]
      }),
      email:[""],
      contactNo:[""],

      hobbies:this.formbuilder.array([new FormControl("Sports"),new FormControl("Music")])
    })
   }

  

  ngOnInit(): void {
  }

  get getHobbies()
  {
    return this.reactiveForm.get("hobbies") as FormArray;
  }

  submit()
  {
    console.log(this.reactiveForm.value);
  }

  addHobby()
  {
    this.getHobbies.push(new FormControl());
  }

  updateName()
  {
    this.reactiveForm.patchValue({
      name:"DemoName"
    })
  }

}
