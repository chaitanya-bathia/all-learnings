import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  name="";
  address="";
  panNumber="";

  output="";
  signup()
  {
    this.output = `Name: ${this.name}, Address: ${this.address}, PAN Number: ${this.panNumber}`;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
