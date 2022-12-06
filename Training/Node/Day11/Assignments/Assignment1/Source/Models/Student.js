const mongoose = require('mongoose');


var studentSchema = mongoose.Schema({
    Name:{type:String, required:true},
    Address:{type:String, required:true},
    Fees:{
        Amount:{type:Number, required:true},
        PaymentDate:{type:String, required:true},
        Status:{type:Boolean, required:true}
    },
    Result:{
        Hindi:{type:Number, required:true},
        Eng:{type:Number, required:true},
        Math:{type:Number, required:true},
        Total:{type:Number, required:true},
        Grade:{type:String, required:true}
    }
});

const studentModel = mongoose.model("student",studentSchema);
module.exports = studentModel;