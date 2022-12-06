<template>
  <div>
    <student-form></student-form>
  </div>
</template>

<script>

import StudentForm from './components/StudentForm.vue'

export default {
  name: 'App',
  components: {
    StudentForm
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
