function add(num1:number,num2:number)
{
    console.log(num1+num2);
}

let mySub = function(num1:number,num2:number)
{
    console.log(num1-num2); 
}

let myAdd: (x: number, y: number) => number = function (
    x: number,
    y: number
  ): number {
    return x + y;
  };

  console.log(myAdd(30,50));

add(20,10);
mySub(20,10);