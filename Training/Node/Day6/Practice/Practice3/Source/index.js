const express= require('express');
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

api.post('/customers',(req,res)=>{
    let data1=[];
    fs.readFile('customers.json',"utf-8",(err,data)=>{
        data1=JSON.parse(data);
        console.log(data);
        
        data1.push(req.body);
        console.log(req.body);
        console.log(data1);

        fs.writeFile('./customers.json',JSON.stringify(data1),(err)=>{
            if(err)
            {
                console.log(err);
                return;
            }
            console.log("File Written");
            
        });
        res.send(data1);
        res.end();
    })

    
}).listen(port, ()=>{
    console.log(`Server running and listening on port ${port}`);
})
