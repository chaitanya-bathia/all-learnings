<template>
  <div>
    <h1 class="text-center bg-dark text-white">Rectangle Area</h1><hr>
    <h4>Enter width :</h4>
    <input type="number" placeholder="Enter width" v-model="length">
    <h4>Enter height :</h4>
    <input type="number" placeholder="Enter height" v-model="width"><br/>

    <button class="btn btn-success" @click="calculate">Calculate Area</button>

    <p>Area of Rectangle : {{result}}</p>
  </div>
</template>

<script>
export default {
  name: 'RectangleArea',
  data(){
    return{
      length : 10,
      width : 20,
      result : 0,
    }
  },

  methods:{
    calculate(){
      this.result = this.length * this.width;
    }
  }
}
</script>