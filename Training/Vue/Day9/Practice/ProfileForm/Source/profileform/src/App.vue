<template>
  <div>
    <profile-component></profile-component>
  </div>
</template>

<script>

import ProfileComponent from './components/Profile.vue';

export default {
  name: 'App',
  components: {
    ProfileComponent
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
