const { Console } = require('console');
const express = require('express');
const mongoose = require('mongoose');
const ProductModel = require('../Models/Product');

var router = express.Router();

router.get("/",async (req,res)=>{
    var data = await ProductModel.find().populate("categoryID","categoryName");
    res.send(data);
    res.end();
});

router.post("/",async (req,res)=>{
    var productModel = new ProductModel(req.body);
    var result = await productModel.save();
    res.end();
})

router.delete("/delete", async (req,res)=>{
    var data = ProductModel.find();
    await data.deleteOne({_id:req.body._id}).then(()=>{console.log("Product Deleted.")});
    res.send("Product deleted");
    res.end();
})


router.put("/update", (req,res)=>{
    var data = ProductModel.find();
    data.updateOne({_id:req.body._id},{productName:req.body.productName, productPrice:req.body.productPrice, categoryID:req.body.categoryID}).then(()=>{console.log("Product Updated")});
    res.send("Product updated");
    res.end();
})

module.exports = router;