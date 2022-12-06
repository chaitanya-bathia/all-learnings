<template>
    <div class="container-fluid">
    <div class="row">
        <div class="col text-center bg-dark text-white">
            <h1>Post List</h1>
        </div>
    </div>
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
                        <th>Like</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="post in arrPosts" :key="post.postID">
                        <td>{{post.postID}}</td>
                        <td>{{post.postName}}</td>
                        <td>{{post.postDescription}}</td>
                        <td>{{post.postedDate}}</td>
                        <td><img src="{{post.postedImage}}" alt="test"></td>
                        <td><button class="btn btn-primary" @click="like(post)">Like</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
</template>

<script>
export default {
    name:"PostList",
    data()
    {
        return{
            arrPosts:[
    {postID:1,postName:"DemoPost1",postDescription:"Desc1",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:2,postName:"DemoPost2",postDescription:"Desc2",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:3,postName:"DemoPost3",postDescription:"Desc3",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    ],
            arrLiked:[]
        }
    },
    methods:
    {
        like(post)
        {
            this.arrLiked.push(post);
            this.$emit("getData",this.arrLiked);
        }
    }
}
</script>