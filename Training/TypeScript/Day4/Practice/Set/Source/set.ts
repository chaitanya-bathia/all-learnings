let deptSet = new Set();

deptSet.add(".NET");
deptSet.add("PHP");
deptSet.add("Node/React");
deptSet.add("HR");
deptSet.add("Management");

console.log("Checking to see if set has HR: "+ deptSet.has("HR"));

console.log("Set Size: "+ deptSet.size);

console.log(deptSet.values());

deptSet.delete("Management");

console.log(deptSet.values());