const express = require('express');
const mongoose = require('mongoose');
const employeeModel = require('../../Models/Employee');
var router = express.Router();

router.get("/", (req, res) => {
	employeeModel.find((err, data) => {
		res.send(data);
		res.end();
	})
})

router.post("/",(req,res)=>{
	var data = new employeeModel(req.body);
	data.save();
	res.send();
})

router.delete("/delete",(req,res)=>{
	var data = employeeModel.find();
	data.deleteOne({_id: req.body._id}).then(()=>{console.log("Employee Data deleted successfully")});
	res.send("Employee Deleted");
	res.end();
})

router.put("/update",(req,res)=>{
	employeeModel.updateOne({_id:req.body._id},{FirstName:req.body.FirstName, LastName:req.body.LastName, Assignments: req.body.Assignments}).then(()=>{console.log("Student Updated.")});
	res.send("Employee Data updated.")
	res.end();
})

module.exports = router;