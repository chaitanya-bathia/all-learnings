<template>
  <div>

  <div class="row">
    <div class="col-4 mx-auto">
    <h2 class="text-center"> Post Data</h2>
    <input class="form-control" type="number" placeholder="ID" v-model="post.id"><br>
    <input class="form-control" type="number" placeholder="User ID" v-model="post.user_id"><br>
    <input class="form-control" type="text" placeholder="Title" v-model="post.title"><br>
    <input class="form-control" type="text" placeholder="Post Content" v-model="post.body"><br><br>
    <button class="btn btn-secondary" @click="sendPost">Add Post</button>
    <button class="btn btn-primary"  @click="putPost(post.id)">Edit Post</button>
  </div>
  </div>

  <div class="row">
  <div class="col">
    <table class="table table-bordered table-striped">
      <caption hidden> TABLE</caption>
    <thead>
      <th scope="header">ID</th>
      <th scope="header">User ID</th>
      <th scope="header">Title</th>
      <th scope="header">Post Data</th>
    </thead>
    <tbody>
      <tr v-for="post in posts" :key="post.id">
        <td>{{post.id}}</td>
        <td>{{post.user_id}}</td>
        <td>{{post.title}}</td>
        <td>{{post.body}}</td>
        <td><button class="btn btn-primary" @click="editPost(post.id)">Edit</button></td>
        <td><button class="btn btn-danger" @click="deletePost(post.id)">Delete</button></td>
    </tr>
    </tbody>
  </table>
  </div>
  </div>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'App',
  components: {
    
  },

  data()
  { 
    return{

      post:{id:0,user_id:0,title:"",body:""},
      forEdit:{},
      posts:[],
      token:"16a95a5b7206ecf08468f8beabf90c5f8a29515ef2ecf935a13536c12ee3e3c6"
    }
  },
  methods:{
    async sendPost()
    {
        try{
          const res = await axios.post("https://gorest.co.in/public/v2/posts",this.post,{headers:{'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`}});
        console.log(res);
        }
        catch(error)
        {
          console.log(error);
        }
    },

    async editPost(id)
    {
      try{
        const res = await axios.get(`https://gorest.co.in/public/v2/posts/${id}`,{headers:{'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`}});
        this.post = res.data;
        console.log(this.forEdit.title);
      }
      catch(error)
      {
        console.log(error);
      }
    },

    async putPost(id){
      try{
        const res = await axios.put(`https://gorest.co.in/public/v2/posts/${id}`,this.post,{headers:{'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`}});
        this.posts = res.data;
        console.log(this.posts);
      }
      catch(error)
      {
        console.log(error);
      }
    },
    

    async deletePost(id)
    {
      try{
        const res = await axios.delete(`https://gorest.co.in/public/v2/posts/${id}`,{headers:{'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`}});
        this.posts = res.data;
        console.log(this.posts);
      }
      catch(error)
      {
        console.log(error);
      }
    }
  },
  async created(){
    try{
      const res = await axios.get(`https://gorest.co.in/public/v2/posts`,{headers:{'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`}})
        this.posts = res.data;
        console.log(this.posts);
        console.log(res.data)
    }
    catch(error)
    {
      console.log(error);
    } 
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
