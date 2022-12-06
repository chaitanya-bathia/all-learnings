const express = require('express');
const api = express();
const fs = require('fs');
const port = 3001;

api.use(express.json());

api.get('/student',(req,res)=>{
    fs.readFile('./students.json',"utf-8",(err,data)=>{
        var studentData = JSON.parse(data);
        res.send(`${JSON.stringify(studentData)}`);
    })
})

api.get('/student/:id',(req,res)=>{
    fs.readFile('./students.json',"utf-8",(err,data)=>{
        var studentData = JSON.parse(data);
        console.log(data);
        console.log(studentData);
        var result = studentData.find((data)=>{
            return data.ID == parseInt(req.params.id);
        })
        res.send(`${JSON.stringify(result)}`);
    })
})

api.get('/student/:id/fees',(req,res)=>{
    fs.readFile('./students.json',"utf-8",(err,data)=>{
        var studentData = JSON.parse(data);
        console.log(studentData);
        var result = studentData.find((data)=>{
            return data.ID == parseInt(req.params.id);
        })
        result= result.Fees;
        res.send(`${JSON.stringify(result)}`);
        console.log(result);
    })
})

api.get('/student/:id/result',(req,res)=>{
    fs.readFile('./students.json',"utf-8",(err,data)=>{
        var studentData = JSON.parse(data);
        console.log(studentData);
        var result = studentData.find((data)=>{
            return data.ID == parseInt(req.params.id);
        })
        result= result.Result;
        res.send(`${JSON.stringify(result)}`);
        console.log(result);
    })
})

api.listen(port, ()=>{
    console.log("Server started...")
})
