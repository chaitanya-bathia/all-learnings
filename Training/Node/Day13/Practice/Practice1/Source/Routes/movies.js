const express = require('express');
const mongoose = require('mongoose');

const moviesModel = require('../Models/Movies');
const router = express.Router();
const genreModel = require('../Models/Genres');

const validateMovie = require('../Models/Movies');

const app = express();

app.use(express.json());

router.get('/',(req,res)=>{
    moviesModel.movieModel.find((err,data)=>{
        res.send(data);
        res.end();
    })
})

router.post("/",(req,res)=>{
    let movie = new moviesModel.movieModel({title:req.body.title,
        genre:{
        _id: req.body.genre._id,
        name: req.body.genre.name},
        numberInStock:req.body.numberInStock,
        dailyRentalRate: req.body.dailyRentalRate
    })
    movie.save();
    res.send(movie);
    res.end();
})

module.exports = router;