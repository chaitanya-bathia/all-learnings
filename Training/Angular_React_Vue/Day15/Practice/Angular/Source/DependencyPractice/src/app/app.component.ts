import { Component } from '@angular/core';
import { GreetingService } from './greeting.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'DependencyPractice';
  name="";
  msg="abcd";

  constructor(private greeting: GreetingService)
  {
    
  }

  greet()
  {
    this.msg= this.greeting.sendMessage(this.name);
  }
}
