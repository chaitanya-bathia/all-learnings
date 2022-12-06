<template>
  <div>
    <input type="number" v-model="num1" placeholder="Number 1" />
    <input type="number" v-model="num2" placeholder="Number 2" />

    <p v-if="num1 > num2">{{ num1 }} is Greater</p>
    <p v-else>{{ num2 }} is Greater</p>
  </div>
</template>

<script>
export default {
    name:'GreaterOfTwo',
    data()
    {
        return{
            num1:0,
            num2:0
        }
    }
}
</script>