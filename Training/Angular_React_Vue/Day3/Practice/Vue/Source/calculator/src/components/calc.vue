<template>
  <div>
    <label>Number 1:</label>
    <input type="number" v-model="num1" /><br>
	<label>Number 2:</label>
    <input type="number" v-model="num2" /><br><br>

    <button @click="sum()">+</button>
    <button @click="subtract()">-</button>
    <button @click="multiply()">*</button>
    <p>{{ result }}</p>
  </div>
</template>

<script>
export default {
  name: "CalcComponent",
  data() {
    return {
      num1: 20,
      num2: 10,
      result: 0,
    };
  },

  methods: {
    sum() {
      this.result = this.num1 + this.num2;
    },

    subtract() {
      this.result = this.num1 - this.num2;
    },

    multiply() {
      this.result = this.num1 * this.num2;
    },
  },
};
</script>

<style scoped>
@import url("../../node_modules/bootstrap/dist/css/bootstrap.min.css");
</style>