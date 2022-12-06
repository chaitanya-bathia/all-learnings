<template>
  <div>
    <calc-component></calc-component>
  </div>
</template>

<script>

import CalcComponent from './components/calc.vue'

export default {
  name: 'App',
  components: {
    CalcComponent
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
