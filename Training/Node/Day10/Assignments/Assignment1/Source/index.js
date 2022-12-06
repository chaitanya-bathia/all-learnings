const express = require('express');
const mongoose = require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/demodb');

const student = require('./Controller/students/student.controller');
const studentModel = require('./Models/Student');

const employee = require('./Controller/employees/employee.controller');
const employeeModel = require('./Models/Employee');

var app = express();
app.use(express.json());

app.use("/student",student);
app.use("/employee",employee);

app.listen(3001,()=>{
    console.log("Server running at port 3001...");
})
