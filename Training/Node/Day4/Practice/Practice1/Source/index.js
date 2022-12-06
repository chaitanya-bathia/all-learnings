require('dotenv').config();
var http = require("http");

const path = require('path');

const fs = require("fs");

console.log(process.env.port);


var url = "http://localhost:3000";
var url1 = new URL("/foo?id=20",url);
console.log(url1.searchParams.get("id"));

// http.createServer((req,res)=>{
// if(req.url="/")
// {
//     fs.readFile("./info.json",(err,data)=>{
//             console.log(JSON.parse( data));
//     })
// }
// res.end();

// }).listen(process.env.port,()=>{
//     console.log(`Server started at ${process.env.port}`)
// });

console.log(path.parse(__filename));