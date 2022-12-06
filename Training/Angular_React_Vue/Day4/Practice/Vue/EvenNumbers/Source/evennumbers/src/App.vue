<template>
  <even-numbers></even-numbers>
</template>

<script>
import EvenNumbers from './components/EvenNumbers.vue'

export default {
  name: 'App',
  components: {
    EvenNumbers
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
