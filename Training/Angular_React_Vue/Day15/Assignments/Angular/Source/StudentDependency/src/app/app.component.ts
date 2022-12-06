import { Component } from '@angular/core';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'StudentDependency';
  msg="";
  username="";
  password="";

  isLoggedin:boolean=false;
  constructor(private auth:AuthService){

  }

  login()
  {
    this.msg = "";
    if (!this.auth.login(this.username, this.password)) {
      this.msg = "user not found";
    }
    else{
      this.isLoggedin=true;
    }
    return false;
  }
}
