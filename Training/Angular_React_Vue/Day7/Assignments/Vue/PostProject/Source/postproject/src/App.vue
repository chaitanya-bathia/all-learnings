<template>
  <div>
    <post-list @getData="fillArray($event)"></post-list>

    <button class="btn btn-success" @click="tableCheck=true">Liked: {{arrLiked.length}}</button>

    <div class="container-fluid" v-if="tableCheck==true">
    <div class="row">
        <div class="col">
            <table class="table table-striped table-hover">
                <caption hidden>Post List Table</caption>
                <thead>
                    <tr>
                        <th>Post ID</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Date</th>
                        <th>Image</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="post in arrLiked" :key="post.postID">
                        <td>{{post.postID}}</td>
                        <td>{{post.postName}}</td>
                        <td>{{post.postDescription}}</td>
                        <td>{{post.postedDate}}</td>
                        <td><img src="{{post.postedImage}}" alt=""></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
  </div>
</template>

<script>
import PostList from './components/PostList.vue'

export default {
  name: 'App',
  components: {
    PostList
  },
  data()
  {
    return{
      arrLiked:[], 
      tableCheck:false 
    }
  },
  methods:{
    fillArray(arrIn)
    {
      this.arrLiked=arrIn;
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
}
</style>
