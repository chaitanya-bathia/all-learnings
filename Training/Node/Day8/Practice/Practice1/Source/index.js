const express = require('express');
const fs = require('fs');
const app = express();
const port = 3001;

const router = express.Router();

app.use(express.json());

router.get('/',(req,res,next)=>{
    let data1=[];
    fs.readFile('./users.json',(err,data)=>{
        data1 = JSON.parse(data);
        res.send(data1);
        console.log(data1);
    })
})

router.get('/login',(req,res,next)=>{
    console.log(req.body)
    let user={
        username :req.body.username,
        password : req.body.password
    }

    if(user.username=="admin" && user.password=="admin"){
        res.send("Login Successful");
    }
    else{
        res.send("Login Failed.");
    }
    res.end();
})

app.listen(port,()=>{
    console.log("Server running...")
})

app.use('/', router);
