<template>
  <div class="text-center">
    <h1 class="text-center bg-danger text-white">Sign Up</h1><hr>

    <div class="container">
        <div class="row">
            <div class="col-6 mx-auto text-center">
                <table class="text-center">
                  <caption hidden>Table</caption>
                    <tr>
                        <th scope="labels"><h3>Enter Name:</h3></th>
                        <td><input type="text" placeholder="Please Enter Name" v-model="name"/></td>
                    </tr>
                    <tr>
                        <th scope="labels"><h3>Enter Address :</h3></th>
                        <td><input type="text" placeholder="Please Enter Address" v-model="address"/></td>
                    </tr>
                    <tr>
                        <th scope="labels"><h3>Enter PAN Number:</h3></th>
                        <td><input type="text" placeholder="Please Enter Pan-number" v-model="pan"/></td>
                    </tr>
                    <tr>
                        <td colspan="2"><button class="btn btn-info" @click="signup">Sign Up</button></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <p>{{result}}</p>
  </div>
</template>

<script>
export default {
  name: 'SignupPage',
  data(){
    return{
      name : '',
      address : '',
      pan : '',
      result : '',
    }
  },

  methods:{
    signup(){
          if(this.name !="" && this.address!=" " && this.pan!=""){
            this.display();
            alert("Sign up Successfully completed!!!")
          }
          else{
            alert("Please fill all fields..")
          }
        },

        display(){
            this.result = `Name : ${this.name}, Address : ${this.address}, Pan-Number : ${this.pan}`
        }
    }
}
</script>

