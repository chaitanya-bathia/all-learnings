const mongoose = require('mongoose');
const joi = require('joi');
const { genreSchema } = require('./Genres');

const moviesSchema = mongoose.Schema({
    title:{
        type:String,
        required:true,
        minlength:5,
        maxlength:255
    },
    genre:{
        type: genreSchema,
        required:true
    },
    numberInStock:{
        type:Number,
        required:true,
        min:0,
        max:255
    },
    dailyRentalRate:{
        type:Number,
        required:true,
        min:0,
        max:255
    }
})

const movieModel = mongoose.model("movieModel",moviesSchema);

function validateMovie(movie){
    const schema = {
        title: joi.String().min(5).max(50).required(),
        genreId: joi.String().required(),
        numberInStock : joi.Number().min(0).required(),
        dailyRentalRate : joi.Number().min(0).required()
    }
    return joi.valid(movie,schema);
}

// module.exports = movieModel, moviesSchema,validateMovie;

exports.movieModel = movieModel;
exports.moviesSchema = moviesSchema;
exports.validateMovie = validateMovie;