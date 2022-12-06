const express = require('express');
const mongoose = require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/moviesdb')
const app = express();
const router = express.Router();


app.use(express.json());
const genre = require('./Models/Genres');
const genreController = require ('./Routes/genres');
const movieController = require('./Routes/movies')

app.use("/genre",genreController);
app.use("/movie",movieController);

app.listen(3001,()=>{console.log("Server running at 3001")});