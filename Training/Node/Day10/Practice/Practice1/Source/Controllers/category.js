const express = require('express');
const mongoose = require('mongoose');
const categoryModel = require('../Models/Catergory');

var router = express.Router();

router.get("/",(req,res)=>{
    categoryModel.find((err,data)=>{
        res.send(data);
        res.end();
    })
})

router.post("/",(req,res)=>{
    var data = new categoryModel(req.body);
    data.save();
    res.end();
})

router.delete("/delete",(req,res)=>{
    var data = categoryModel.find();
    data.deleteOne({_id:req.body._id}).then(()=>{console.log("Data deleted")});
    res.send("Data Deleted");
    res.end(); 
})

router.put("/update",(req,res)=>{
    categoryModel.updateOne({_id:req.body._id},{categoryName:req.body.categoryName}).then(()=>{console.log("Data Updated.")});
    res.send("Data updated.");
    res.end();
})

module.exports = router;

