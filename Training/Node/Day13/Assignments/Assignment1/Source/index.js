const mongoose = require('mongoose');
const express = require('express');
const router = express.Router();
const connect = mongoose.connect('mongodb://localhost:27017/hospitaldb')

const app = express();

app.use(express.json());

const doctorModel = require('./Models/Doctor');
const doctorController = require('./Controllers/doctor');
const patientModel = require('./Models/Patient');
const patientController = require('./Controllers/patient');


app.use("/doctor",doctorController);
app.use("/patient",patientController);

app.listen(3001,()=>{
    console.log("Server running at 3001...")
})