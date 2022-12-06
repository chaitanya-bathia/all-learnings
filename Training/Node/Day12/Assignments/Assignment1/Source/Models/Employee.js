const mongoose = require('mongoose');

var employeeSchema = mongoose.Schema({
    FirstName:{type:String, required:true, uppercase:true, trim:true},
    LastName:{type:String, required:true, uppercase:true, trim:true},
    Assignments:[
        {
            AssignmentID:{type:Number, required:true, uppercase:true, trim:true},
            AssignmentCategory:{type:String, required:true, uppercase:true, trim:true},
            AssignmentName:{type:String, required:true, uppercase:true, trim:true},
            AssignmentStatus:{type:String, required:true, uppercase:true, trim:true},
        }
    ]
});

const employeeModel = mongoose.model("employee",employeeSchema)
module.exports = employeeModel;