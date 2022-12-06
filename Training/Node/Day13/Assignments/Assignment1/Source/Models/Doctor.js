const mongoose = require('mongoose');

const doctorSchema = mongoose.Schema({
    name:{type:String,required:true,minlength:3,maxlength:250},
    speciality:{type:String,required:true,minlength:3,maxlength:250},
    qualification:{type:String,required:true,minlength:1,maxlength:250},
    patients:[{
        patientId:{
            type:mongoose.Schema.Types.ObjectId,
            ref:"patient"}
    }]
})

const doctorModel = mongoose.model("doctor",doctorSchema);
module.exports = doctorModel;