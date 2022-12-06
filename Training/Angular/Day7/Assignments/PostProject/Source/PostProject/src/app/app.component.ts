import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PostProject';

  tableCheck=false;
  arrLiked:Array<any>=[];

  getArray(arrLiked:Array<any>[])
  {
    this.arrLiked=arrLiked;
  }

  displayLiked()
  {
    this.tableCheck=true;
  }

}
