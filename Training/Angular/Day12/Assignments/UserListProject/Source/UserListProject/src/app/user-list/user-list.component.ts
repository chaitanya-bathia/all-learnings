import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {

  userDetails:Array<any>= [{userID:"1",userName:"Roy",Gender:"Male",designation:"Developer",PanNumber:"335454"},{userID:"2",userName:"Rohit",Gender:"Male",designation:"Junior Developer",PanNumber:"abcd"}]

  inUserID:any="";
  selected:Array<any>=[];
  constructor(private activeRoute:ActivatedRoute) { }

  ngOnInit(): void {
    this.activeRoute.params.subscribe(p=>{
      this.inUserID=p["id"];
      this.selected=this.userDetails.filter(e=>e.userID==this.inUserID);
      
    })
  }
}
