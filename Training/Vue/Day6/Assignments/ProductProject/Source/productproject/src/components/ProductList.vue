<template>
    <div class="container-fluid my-4">
        <h1 class="bg-info">Product List</h1>
        <div class="row">
            <div class="col">
                <table class="table table-striped table-hover">
                    <caption hidden>table</caption>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Quantity</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="product in arrProduct" :key="product.productName">
                            <td>{{product.productName}}</td>
                            <td>{{product.price}}</td>
                            <td>{{product.quantity}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name:"ProductList",
    props:
    {
        arrProduct:Array,
    }
}
</script>