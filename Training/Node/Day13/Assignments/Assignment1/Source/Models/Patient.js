const mongoose = require('mongoose');

const patientSchema = new mongoose.Schema({
    firstName:{type:String,required:true,minlength:3,maxlength:250},
    lastName:{type:String,required:true,minlength:3,maxlength:250},
    disease:{type:String,required:true,minlength:5,maxlength:250},
    healthcareAssistant:[{
        assistantId:{type:Number,required:true},
        assistantName:{type:String,required:true,minlength:3,maxlength:250},
        department:{type:String,required:true,minlength:3,maxlength:250}
    }],
    medicine:[{
        name:{type:String,required:true,minlength:3,maxlength:250},
        morning:{type:Boolean,default:true},
        afternoon:{type:Boolean,default:true},
        night:{type:Boolean,default:true}
    }]
})


const patientModel = mongoose.model("patient",patientSchema);
module.exports = patientModel;