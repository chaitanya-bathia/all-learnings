const mongoose = require('mongoose');
const joi = require('joi');

var genreSchema = mongoose.Schema({
    name:{
        type:String,
        required:true,
        minlength:5,
        maxlength:255
    }
})

const genreModel = mongoose.model("genre",genreSchema);

function validateGenre(genre){
    const schema = {
        name : joi.string().min(3).required()
    };

    return joi.valid(genre,schema);
}



exports.genreSchema = genreSchema;
exports.genreModel = genreModel;
exports.validateGenre = validateGenre;
