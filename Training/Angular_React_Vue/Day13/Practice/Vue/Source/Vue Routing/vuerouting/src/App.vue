<template>
  <div>   
  <h1 class="bg-success text-white">Routing</h1>
  <router-link class="btn btn-warning" to="/practice">Go To Practice page</router-link><br/><br/>
  <router-link class="btn btn-warning" to="/helloworld">Go To Hello World page</router-link>
  <div>
    <router-view></router-view>
  </div>
  </div>
</template>

<script>
export default {
  name: 'App',
  components: {
    
  }
}
</script>



<style>
@import url('../node_modules/bootstrap/dist/css/bootstrap.min.css');
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
