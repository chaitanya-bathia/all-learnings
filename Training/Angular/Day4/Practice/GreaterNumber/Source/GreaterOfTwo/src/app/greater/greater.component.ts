import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-greater',
  templateUrl: './greater.component.html',
  styleUrls: ['./greater.component.css']
})
export class GreaterComponent implements OnInit {

  num1=0;
  num2=0;

  constructor() { }

  ngOnInit(): void {
  }

}
