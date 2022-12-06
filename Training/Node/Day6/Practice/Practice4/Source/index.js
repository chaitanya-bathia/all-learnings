const express = require('express');
const api = express();
const fs = require('fs');
const port = 3001;

api.use(express.json());

api.get('/customers',(req,res)=>{
    fs.readFile('./customers.json',"utf-8",(err,data)=>{
        console.log(data);
        res.send(data);
        res.end();
    })
})

api.put('/customers/:id',(req,res)=>{
    data1=[];
    fs.readFile('./customers.json',"utf-8",(err,data)=>{
        data1=JSON.parse(data);
        const result = data1.find((data)=>{
            return data.id === parseInt(req.params.id)
        })

        result.name = req.body.name;
        fs.writeFile("./customers.json", JSON.stringify(data1), (err)=>{
            console.log("Name of First is Updated");
        })
        res.send(data1);
        res.end();
    })
}).listen(port, ()=>{
    console.log("Server running at 3001:.....")
})