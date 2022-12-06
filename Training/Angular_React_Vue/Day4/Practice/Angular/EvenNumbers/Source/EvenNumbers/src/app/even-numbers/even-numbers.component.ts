import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-even-numbers',
  templateUrl: './even-numbers.component.html',
  styleUrls: ['./even-numbers.component.css']
})
export class EvenNumbersComponent implements OnInit {

  constructor() { }

  list:Array<number>=[];
  generateArray()
  {
    for (let i = 0; i < 100; i++) {
      this.list[i] = i+1;
    }
  }
  ngOnInit(): void {
  }

}
