const express = require('express');
const mongoose = require('mongoose');
const connect = mongoose.connect('mongodb://localhost:27017/testdb');
const category = require('./Controllers/category');
const categoryModel = require('./Models/Catergory');

const product = require('./Controllers/product');
const productModel = require('./Models/Product');
var app = express();


app.use(express.json());

app.use("/category",category);
app.use("/products",product);


app.listen(3001,()=>{
    console.log("Server running at 3001.....")
})