import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {

  num1:number=10;
  num2:number=20;
  ans:number=0;


  add()
  {
    this.ans=this.num1+this.num2;
  }

  subtract()
  {
    this.ans=this.num1-this.num2;
  }

  multiply()
  {
    this.ans=this.num1*this.num2;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
