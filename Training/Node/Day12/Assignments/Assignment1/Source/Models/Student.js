const mongoose = require('mongoose');


var studentSchema = mongoose.Schema({
    Name:{type:String, required:true, uppercase:true, trim:true},
    Address:{type:String, required:true, uppercase:true, trim:true},
    Fees:{
        Amount:{type:Number, required:true, uppercase:true, trim:true},
        PaymentDate:{type:String, required:true, uppercase:true, trim:true},
        Status:{type:Boolean, required:true, uppercase:true, trim:true}
    },
    Result:{
        Hindi:{type:Number, required:true, uppercase:true, trim:true},
        Eng:{type:Number, required:true, uppercase:true, trim:true},
        Math:{type:Number, required:true, uppercase:true, trim:true},
        Total:{type:Number, required:true, uppercase:true, trim:true},
        Grade:{type:String, required:true, uppercase:true, trim:true}
    }
});

const studentModel = mongoose.model("student",studentSchema);
module.exports = studentModel;