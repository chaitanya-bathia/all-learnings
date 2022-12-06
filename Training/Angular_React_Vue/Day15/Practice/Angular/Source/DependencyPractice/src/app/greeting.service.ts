import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetingService {

  constructor() { }

  sendMessage(name:string)
  {
    return "Greetings of the day, " + name;
  }
}
