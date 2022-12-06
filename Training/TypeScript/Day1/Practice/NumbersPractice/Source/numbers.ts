var num: number = 0.12345;
var ans: string = num.toFixed(2);
console.log("Decimal Number with Fixed Decimal : " + ans);

// toprecision method
var ans: string = num.toPrecision(3);
console.log("Decimal Number with precision method : " + ans);

// toexponentional method
var num1: number = 5435234;
var ans: string = num1.toExponential();
console.log("Decimal Number with exponentional method : " + ans);

// min number in array
var result: number = Math.min(58, 95, 32, 35, 64, 6, 2);
console.log("Min number from Array : " + result);

// max number in array
var result: number = Math.max(58, 95, 32, 35, 64, 6, 2);
console.log("Max number from Array : " + result);

