const mongoose = require('mongoose');

var employeeSchema = mongoose.Schema({
    FirstName:{type:String, required:true},
    LastName:{type:String, required:true},
    Assignments:[
        {
            AssignmentID:{type:Number, required:true},
            AssignmentCategory:{type:String, required:true},
            AssignmentName:{type:String, required:true},
            AssignmentStatus:{type:String, required:true},
        }
    ]
});

const employeeModel = mongoose.model("employee",employeeSchema)
module.exports = employeeModel;