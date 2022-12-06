<template>
  <employee-form></employee-form>
</template>

<script>

import EmployeeForm from './components/EmployeeForm.vue'

export default {
  name: 'App',
  components: {
    EmployeeForm
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
}
</style>
