const express = require('express');
const mongoose = require('mongoose');
const genreModel = require('../Models/Genres')
const validateGenre = require('../Models/Genres')
const router = express.Router();

const app = express();
app.use(express.json());

router.get("/", (req, res) => {
    genreModel.genreModel.find((err, data) => {
        res.send(data);
        res.end();
    });

})

router.post("/", (req,res)=>{
    // const {error} = validateGenre.validateGenre(req.body.name);
    // if(error){
    //     return res.status(400).send(error);
    // }
    let genre = new genreModel.genreModel({name:req.body.name})
    console.log(req.body.name);
    genre.save();
    res.send(genre);
    res.end();
})

module.exports = router;
