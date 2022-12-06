import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UserListProject';

  userList:Array<any>=[{"userID":1,"userName":"Roy"},{"userID":2,"userName":"Rohit"}]
}
