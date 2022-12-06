const mongoose = require("mongoose");
var category=require("./Catergory");
const productSchema = new mongoose.Schema({
    productName: { type: String, required: true, trim: true, uppercase: true },
    productPrice: { type: Number, required: true, trim: true },
    categoryID:  {
        type: mongoose.Schema.Types.ObjectId,
        ref: "category",
        required: true,
        trim: true,
      }
  });

  
const ProductModel = mongoose.model("product", productSchema);

module.exports = ProductModel;