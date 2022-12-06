<template>
  <div>
    <profile-component @getData="display($event)"></profile-component>
    <p>{{username}}</p>
  </div>

</template>

<script>
import ProfileComponent from './components/Profile.vue'

export default {
  name: 'App',
  components: {
    ProfileComponent
  },
  data()
  { 
    return{
      username:""
    }
  },
  methods:
  {
    display(username)
    {
      this.username=username;
    }    
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
