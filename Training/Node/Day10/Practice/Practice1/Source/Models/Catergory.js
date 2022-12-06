const mongoose = require('mongoose');

var categorySchema = mongoose.Schema({
    categoryName: {type:String}
});

const categoryModel = mongoose.model("category",categorySchema);
module.exports = categoryModel;