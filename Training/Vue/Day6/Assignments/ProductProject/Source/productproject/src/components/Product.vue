<template>
    <div class="container-fluid">
        <h1 class="bg-warning text-center">Product</h1>
        <div class="row">
            <div class="col-4 mx-auto">
                <label for="txtName">Product Name:</label>
                <input type="text" class="form-control" id="txtName" v-model="objProduct.productName"><br>

                <label for="numPrice">Price:</label>
                <input type="number" class="form-control" id="numPrice" v-model="objProduct.price"><br>

                <label for="numQuantity">Quantity:</label>
                <input type="number" class="form-control" id="numQuantity" v-model="objProduct.quantity"><br>

                <button @click="addProduct" class="btn btn-success">Add Product</button>
                <br>
            </div>
        </div>
        <product-list v-bind:arrProduct="arrProduct"></product-list>
    </div>
    
</template>

<script>
import ProductList from './ProductList.vue'
export default {
  components: { ProductList },
    name:'ProductComponent',

    data()
    {
        return{
            objProduct : {ProductName:"",price:0,quantity:0},

            arrProduct:[]
        }
    },
    methods:
    {
        addProduct()
        {
            if(this.objProduct.productName==""|| this.objProduct.price==0|| this.objProduct.quantity==0)
            {
                alert("Invalid Entry. Try Again.");
            }
            else
            {
                this.objProduct.price=this.objProduct.price-(this.objProduct.price*0.05); 
                this.arrProduct.push(this.objProduct);
            }
        }
    }
}
</script>