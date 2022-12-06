const express = require('express');
const jwt = require('jsonwebtoken');

const login = require('./Controllers/login');
const product = require('./Controllers/product')

const app = express();
global.config = require('./config')
app.use(express.json());

app.use("/login",login);
app.use("/product",product);

app.listen(3001,()=>{
    console.log("Server running....");
})