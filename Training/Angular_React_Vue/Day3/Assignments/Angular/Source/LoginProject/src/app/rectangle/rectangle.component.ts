import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})
export class RectangleComponent implements OnInit {

  length=0;
  width=0;
  result:(number|string)="result will appear here..."

  calculateArea()
  {
    this.result=this.length*this.width;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
