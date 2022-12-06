const express = require('express');
const fs = require('fs');

var expInstance = express();
const port = 3001;

expInstance.get('/customers',(req,res)=>{
    fs.readFile('./person.json','utf-8',(err,data)=>{
        if(err)
        {
            console.log(err);
            return;
        }
        res.send(JSON.parse(data));
    });
    
}).listen(port,()=>{
    console.log(`Server running. Listening at port ${port}`);
})