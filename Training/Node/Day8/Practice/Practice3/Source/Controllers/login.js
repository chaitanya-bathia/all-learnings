const jwt = require('jsonwebtoken');
const express = require('express');
const app = express();

var router = express.Router();

router.post("/",(req,res)=>{
    if(req.body.username=="admin" && req.body.password=="admin"){
        var user = {"username":req.body.username, "role":"admin" }
        jwt.sign(user,global.config.key,{expiresIn:"1m",algorithm:"HS256"},(err,token)=>{
            if(err){
                console.log(err);
                res.send(err);
            }
            else{
                res.send({message:"Login Successful",tokenInfo:token});
            }
        })
    }
    else{
        res.send("Invalid user");
    }
})

module.exports = router;