<template>
<div class="container-fluid">
    <div class="row">
        <div class="col">
            <h1 class="text-center bg-warning">Profile</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-4 mx-auto">
            <input type="text" placeholder="Name here" class="form-control" v-model="username">
            <p>{{username}}</p>

            <button class="btn btn-warning" @click="sendData()">Send</button>
        </div>
    </div>
</div>
</template>

<script>
export default {
    name:"ProfileComponent",
    data()
    {
        return{
            username:""
        }
    },
    methods:
    {
        sendData()
        {
            this.$emit("getData",this.username);
        }
    }
}
</script>