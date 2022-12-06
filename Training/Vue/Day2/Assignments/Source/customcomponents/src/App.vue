<template>
  <div>
    <header-component></header-component>
    <section-component></section-component>
    <footer-component></footer-component>
  </div>
</template>

<script>
import HeaderComponent from './components/Header.vue';
import SectionComponent from './components/Section.vue';
import FooterComponent from './components/Footer.vue';

export default {
  name: 'App',
  components: {
    HeaderComponent,
    SectionComponent,
    FooterComponent
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
