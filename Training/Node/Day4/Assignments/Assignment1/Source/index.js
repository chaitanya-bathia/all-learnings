
const http = require('http');

const fs = require('fs');

var url = "http://localhost:3001";


//Assignment task1

// var url1 = new URL('/',url);

// http.createServer((req,res)=>
// {
    
//     if(req.url="/")
//     {
//         fs.readFile('./person.json',(err,data)=>{
//             if(err)
//             {
//                 console.log(err);
//                 return;
//             }
//             console.log(JSON.parse(data));
//         })
//     }
//     res.end();
// }).listen(3001,()=>{console.log("Server Started at port 3001...")})



//Assignment task 2

// var url2 = new URL("/product?param1=5&param2=10",url);
// let param1 = parseInt(url2.searchParams.get("param1"));
// let param2 = parseInt(url2.searchParams.get("param2"));

// http.createServer((req,res)=>{
//     if(req.url="/product?param1=5&param2=10")
//     {
//         res.write((param1+param2).toString());
//     }

//     res.end();
// }).listen(3001,()=> {console.log("Server started. listening on post 3001...")})




//Assignment task3

// var url3 = new URL("/",url);

// http.createServer((req,res)=>{
//     if(req.url="/"){
//         fs.readFile("./test.json",(err,data)=>{
//             if(err){
//                 console.log(err);
//                 return;
//             }
//             let name = JSON.parse(data).name;
//             name = name.split('');
//             console.log(name);
//             for(let i=0;i<name.length;i++){
//                 if(name[i]=="a"||name[i]=="A"||name[i]=="e"||name[i]=="E"||name[i]=="i"||name[i]=="I"||name[i]=="o"||name[i]=="O"||name[i]=="u"||name[i]=="U"){
//                     console.log(name[i]);
//                     break;
//                 }
//             }
//         })
//         res.end();
//     }
// }).listen(3001, ()=> {console.log("Server started. listening on post 3001...")});




//Assignment 4

var url4 = new URL ("/",url);
http.createServer((req,res)=>{
    if(req.url=="/upload")
    {
        fs.readFile('data.txt', "utf-8", (err,data)=>{
            let content = data;
            fs.writeFile("./uploaded.txt", content, {flag: 'w+'}, err =>{
                if(err)
                {
                    console.log(err);
                }
                else{
                    res.write("Data uploaded successfully");
                }
                res.end();
            })
        })
    }
}).listen(3001, ()=>{console.log("Server Running on port 3001")});

