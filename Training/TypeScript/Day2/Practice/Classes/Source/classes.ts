class testClass {
    message: string;
   
    constructor(message: string) {
      this.message = message;
    }
   
    greet() {
      console.log("Hello, " + this.message);
    }
  }
   
  let greeter = new testClass("world");
  greeter.greet();


  //adder example
  class calc
  {
      num1:number;
      num2:number;

      constructor(num1:number, num2:number)
      {
          this.num1=num1;
          this.num2=num2;
      }
      add()
      {
          console.log(this.num1+this.num2);
      }
  }

  var adder = new calc(10,20);
  adder.add();
  //inheritance

  class Animal {
    move(distanceInMeters: number = 0) {
      console.log(`Animal moved ${distanceInMeters}m.`);
    }
  }
   
  class Cat extends Animal {
    meow() {
      console.log("Meow!");
    }
  }
   
  const cat = new Cat();
  cat.meow();
  cat.move(10);  // move method belongs to class Animal but after inheritance, it works with Cat class
  cat.meow();