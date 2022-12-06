<template>
    <div>
        <button @click="generateArray">Click here.</button>
        <div v-for="item in list" :key="item">
            <p v-if="item%2==0">{{item}}</p>
        </div>
    </div>
</template>

<script>

export default {
        name:'EvenNumbers',
       data()
       {
           return{
               list:[]
           }
       },
       methods:
       {
           generateArray()
           {
               for (let i = 0; i < 100; i++) {
                   this.list[i]=i+1;
               }
           }
       }
}
</script>