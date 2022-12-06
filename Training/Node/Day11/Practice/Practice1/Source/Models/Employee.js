const mongoose = require('mongoose');

var employeeSchema = mongoose.Schema({
    FirstName:{type:String},
    LastName:{type:String},
    Assignments:[
        {
            AssignmentID:{type:Number},
            AssignmentCategory:{type:String},
            AssignmentName:{type:String},
            AssignmentStatus:{type:String},
        }
    ]
});

const employeeModel = mongoose.model("employee",employeeSchema)
module.exports = employeeModel;