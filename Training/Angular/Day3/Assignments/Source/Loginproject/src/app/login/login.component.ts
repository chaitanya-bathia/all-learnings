import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username="";
  password="";
  result="Click login to continue";
  
  validateLogin()
  {
    if(this.username=="admin" && this.password=="admin")
    {
      
      this.result="Valid";
      return true;
    }
    else
    {
      this.result="Invalid";
      return false;
      
    }
  }
  constructor() { }



  ngOnInit(): void {
  }

}
