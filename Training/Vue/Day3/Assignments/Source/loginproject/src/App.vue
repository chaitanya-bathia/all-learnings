<template>
  <div>
    <login-component></login-component>
    <signup-page></signup-page>
    <rectangle-area></rectangle-area>
  </div>
</template>

<script>
import LoginComponent from "./components/Login.vue";
import RectangleArea from "./components/Rectangle.vue";
import SignupPage from "./components/Signup.vue";

export default {
  name: "App",
  components: {
    LoginComponent,
    RectangleArea,
    SignupPage,
  },
};
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
