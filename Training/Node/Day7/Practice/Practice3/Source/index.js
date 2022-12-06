const express = require('express');
const fs = require('fs');
const app = express();
const port = 3001;
app.use(express.json());

app.get('/users',(req,res,next)=>{
    fs.readFile('./FileExist.json',(err,data)=>
    {
        if(err){
            next(err);
        }
        else{
            console.log("data Read");
        }
    })
})

app.use((err,req,res,next)=>{
    console.log(err.stack);
    res.status(500).send('Something broke...');
})

app.listen(port, ()=>{
    console.log(`Server running on port ${port}.....`);
})
