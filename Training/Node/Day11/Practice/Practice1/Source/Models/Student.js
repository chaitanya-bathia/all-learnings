const mongoose = require('mongoose');


var studentSchema = mongoose.Schema({
    Name:{type:String},
    Address:{type:String},
    Fees:{
        Amount:{type:Number},
        PaymentDate:{type:String},
        Status:{type:Boolean}
    },
    Result:{
        Hindi:{type:Number},
        Eng:{type:Number},
        Math:{type:Number},
        Total:{type:Number},
        Grade:{type:String}
    }
});

const studentModel = mongoose.model("student",studentSchema);
module.exports = studentModel;