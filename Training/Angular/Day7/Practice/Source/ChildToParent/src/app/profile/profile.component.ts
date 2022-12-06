import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  @Output() dataEvent = new EventEmitter<any>();

  
  username='';

  constructor() { }

  ngOnInit(): void {
  }

  sendData()
  {
    this.dataEvent.emit(this.username);
  }

}
