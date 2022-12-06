import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form-groups',
  templateUrl: './form-groups.component.html',
  styleUrls: ['./form-groups.component.css']
})
export class FormGroupsComponent implements OnInit {

  reactiveForm = new FormGroup(
    {
      name: new FormControl(''),
      address:new FormGroup(
        {
          flatNo: new FormControl(0),
          area :new FormControl(""),
          city :new FormControl(""),
          state: new FormControl("")
        }
      ),
      email: new FormControl(''),
      contactNo: new FormControl(''),

      hobbies: new FormArray([new FormControl("Sports"), new FormControl("Music")])

    }
  );
  constructor() { }

  ngOnInit(): void {
  }

  submit()
  {
    console.log(this.reactiveForm.value);
  }

  get getHobbies()
  {
    return this.reactiveForm.get("hobbies") as FormArray;
  }

  addHobby()
  {
    this.getHobbies.push(new FormControl(""));
  }

}
