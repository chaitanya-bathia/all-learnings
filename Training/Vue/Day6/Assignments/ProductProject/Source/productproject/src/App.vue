<template>
  <div>
    <product-component></product-component>
  </div>
</template>

<script>
import ProductComponent from './components/Product.vue'

export default {
  name: 'App',
  components: {
    ProductComponent
  },
  
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
