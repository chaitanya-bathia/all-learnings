import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-world-component',
  templateUrl: './hello-world-component.component.html',
  styleUrls: ['./hello-world-component.component.css']
})
export class HelloWorldComponentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  name = 'Chaitanya';

}
