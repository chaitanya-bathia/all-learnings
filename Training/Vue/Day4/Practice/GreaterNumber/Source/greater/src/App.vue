<template>
  <greater-of-two></greater-of-two>
</template>

<script>
import GreaterOfTwo from './components/GreaterOfTwo.vue'

export default {
  name: 'App',
  components: {
    GreaterOfTwo
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
