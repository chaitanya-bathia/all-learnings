<template>
  <div>
    <img alt="Vue logo" src="./assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />
    <alphabet-comp></alphabet-comp>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";
import AlphabetComp from "./components/AlphabetComp.vue";
export default {
  name: "App",
  components: {
    HelloWorld,
    AlphabetComp,
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
  margin-top: 60px;
}
</style>
