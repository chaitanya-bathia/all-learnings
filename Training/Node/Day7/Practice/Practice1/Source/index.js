const express = require('express');
const app = express();
var fs = require('fs');
const port = 3001;

app.use(express.json());

app.use((req,res,next)=>{
    console.log('Time:', new Date());
    next();
})

app.use('/user',(req,res,next)=>{
    console.log(`Request Type: ${req.method}, Original URL: ${req.originalUrl}`);
    next();
})

app.get('/user', (req,res)=>{
    fs.readFile('./demo.json',"utf-8", (err,data)=>{
        console.log(JSON.parse(data));
        res.send(`${JSON.stringify(data)}`);
        res.end();
    })
})

app.listen(port,()=>{
    console.log("Server running at port 3001.....")
})
