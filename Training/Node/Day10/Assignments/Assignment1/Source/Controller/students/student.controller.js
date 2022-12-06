const express = require('express');
const mongoose = require('mongoose');
const studentModel = require('../../Models/Student');
var router = express.Router();

router.get("/", (req, res) => {
	studentModel.find((err, data) => {
		res.send(data);
		res.end();
	})
})

router.post("/",(req,res)=>{
	var data  = new studentModel(req.body);
	data.save();
	res.send();
})

router.delete("/delete",(req,res)=>{
	var data = studentModel.find();
	data.deleteOne({_id: req.body._id}).then(()=>{console.log("Student deleted successfully")});
	res.send("Student Deleted");
	res.end();
})

router.put("/update",(req,res)=>{
	studentModel.updateOne({_id:req.body._id},{Name:req.body.Name, Address:req.body.Address,Fees:req.body.Fees,Result:req.body.Result}).then(()=>{console.log("Student Updated.")});
	res.send("Student Data updated.")
	res.end();
})

router.get("/fees",(req,res)=>{
	studentModel.findById(req.body._id,(err,data)=>{
		res.send(data.Fees);
		res.end();
	});
})

router.get("/result",(req,res)=>{
	studentModel.findById(req.body._id,(err,data)=>{
		res.send(data.Result);
		res.end();
	});
})

module.exports = router;