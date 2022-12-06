let ageMap = new Map();

ageMap.set("Jay",25);
ageMap.set("Meet",30);
ageMap.set("Priya",23);
ageMap.set("Amit",40);



let mapArr = ageMap.entries();

console.log(mapArr);


console.log("Age of Meet is "+ageMap.get("Meet"));

console.log("checking to see if map has Amit: "+ageMap.has("Amit"));

console.log("Size of Map is: "+ageMap.size);

let keys = ageMap.keys();
console.log(keys);

let values=ageMap.values();
console.log(values);

ageMap.delete("Amit");

let newArr = ageMap.entries();

console.log(newArr);