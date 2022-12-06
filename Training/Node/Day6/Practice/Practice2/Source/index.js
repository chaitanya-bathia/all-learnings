const express = require('express');
const api = express();
const fs = require('fs');
const port = 3001;

api.get('/customers/:id',(req,res)=>{
    fs.readFile('./customers.json','utf-8', (err,data)=>{
        const customer = JSON.parse(data);
        const result = customer.find((data)=>{
            return data.id== req.params.id;
        })

        res.send(JSON.stringify(result));
    })
}).listen(port, ()=> {
    console.log(`Server running. Listening at port ${port}`);
})