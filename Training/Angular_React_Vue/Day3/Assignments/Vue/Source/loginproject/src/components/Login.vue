<template>
  <div>
    <h1 class="text-center bg-primary text-white">Login</h1><hr>
    <h4>Enter Username :</h4>
    <input type="text" placeholder="Enter Username" v-model="name">
    <h4>Enter Password :</h4>
    <input type="text" placeholder="Enter Password" v-model="Password"><br/>

    <button class="btn btn-warning" @click="login">Login</button>

    <p>{{result}}</p>
  </div>
</template>

<script>
export default {
  name: 'LoginComponent',
  data(){
    return{
      name : '',
      Password : '',
      result : ''
    }
  },

  methods:{
    login(){
    if(this.name == "admin" && this.Password == "admin")
    {
      this.result = "Login Successfully done!!"
    }
    else if(this.name != "admin"){
      alert("Please enter valid Username")
    }
    else if(this.Password != "admin"){
      alert("Please enter valid password")
    }
    if(this.name != "admin" && this.Password != "admin")
    {
      alert("Please Enter valid Username and password")
    }
    }
  }
}
</script>
