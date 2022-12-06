const mongoose = require('mongoose');
const express = require('express');
const router = express.Router();
const app = express();

app.use(express.json());

const patientModel = require('../Models/Patient');

router.get("/",(req,res)=>{
    patientModel.find((err,data)=>{
        res.send(data);
        res.end();
    })
})

router.post("/",(req,res)=>{
    var patient = new patientModel(req.body);
    patient.save();
    res.send(patient);
    res.end();
})

router.delete("/",(req,res)=>{
    patientModel.deleteOne({_id:req.body._id},()=>{console.log("Patient Data Deleted")});
    res.send("Patient Data Deleted.");
    res.end();
})

module.exports = router;