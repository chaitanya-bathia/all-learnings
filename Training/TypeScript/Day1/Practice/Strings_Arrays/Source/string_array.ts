// charAt(postion) - return char
var str = "This is string and string";
let str1 = "This is another String";
console.log("The position of 6 is ", str.charAt(6));

// charCodeAt(postion) - return char code
console.log("The charCodeAt of 6 is ", str.charCodeAt(6));

// concat - string.concat(string2, string3[, ..., stringN]) 
console.log("str + str1 " + str.concat(str1.toString()));

// indexOf(searchvalue[,fromindex])
let strSearch = str.indexOf("string")
console.log("indexOf found String : " + strSearch);

// lastIndexOf
console.log("Last index of string : ",str.lastIndexOf("string"));

// replace(oldvalue,newvalue)
var re = /apples/gi; 
var str2 = "Apples are round, and apples are juicy.";
var newstr = str2.replace(re, "oranges"); 
console.log(newstr)

// string.split([separator][, limit]);
var str3 = "Apples are round, and apples are juicy."; 
var splitted = str3.split(" ", 3); //" " insted of u write "are" or anything
console.log(splitted)
console.log(str3.toUpperCase());
console.log(str3.toLowerCase());

// localeCompare()- string.localeCompare( param )
let str4 = "This is str";
let index = str4.localeCompare("This is str");
console.log("string matches",index);

// match(expression)
let text = "The rain in SPAIN stays mainly in the plain";
var result = text.match(/in/g);
console.log(result);

// search() string.search(regexp);
let text1 = "Mr. Blue has a blue blue house"
let position = text1.search(/Blue/gi);
if(position == -1){
  console.log("String doesn't match");
}else{
  console.log("String matched at " + position + " position");
}

// slice() , slice(start,end)

var str5 = "Apples are round, and apples are juicy."; 
var sliced = str5.slice(3, -2);// les are round, and apples are juic
console.log(sliced);

// string.substr(start[, length]);
var sbstr = str5.substr(1,4); //pple
console.log(sbstr);

// trim methods
var str6 = "   Good   ";
console.log(str6.trim());

// Array and methods

let fruits: string[] = ['Apple' , 'Orange', 'Banna'];

for(var i in fruits){
    console.log(fruits[i]);
}

var cars: Array<string> = ['Chevrolet','BMW','AMG','Suzuki','Tata'];

console.log(cars.sort());

console.log(cars.pop());


console.log(cars.push('Toyota'));

for(var index1 in cars){
    console.log(cars[index1]);
}

console.log(cars.concat(['Ford','Merce']));

console.log(cars.indexOf('Toyota'));

console.log(cars.shift());
for(var ind in cars){
    console.log(cars[ind]);
}