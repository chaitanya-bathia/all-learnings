<template>
    <div class="container-fluid">
        <div class="row">
            <div class="col bg-dark text-white">
                <h1>Student Form</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-4 mx-auto my-3">
                <form ref="studentForm" @submit.prevent="submit">

                    <label>Personal Details:</label>
                    <input type="text" class="form-control" v-model="v$.studentData.studentName.firstName.$model" placeholder="Student's First Name" /><br>
                    <p v-if="v$.studentData.studentName.firstName.$error">Empty First Name</p>
                    <input type="text" class="form-control" v-model="v$.studentData.studentName.middleName.$model" placeholder="Student's Middle Name" /><br>
                    <p v-if="v$.studentData.studentName.middleName.$error">Empty Middle Name</p>
                    <input type="text" class="form-control" v-model="v$.studentData.studentName.lastName.$model" placeholder="Student's Last Name" /><br>
                    <p v-if="v$.studentData.studentName.lastName.$error">Empty Last Name</p>
                    <input type="date" class="form-control" v-model="v$.studentData.dateOfBirth.$model" placeholder="Student's Date of Birth" /><br>
                    <p v-if="v$.studentData.dateOfBirth.$error">Empty Date Of Birth</p>
                    <input type="text" class="form-control" v-model="studentData.placeOfBirth" placeholder="Student's Birth place" /><br>
                    <input type="text" class="form-control" v-model="studentData.firstLanguage" placeholder="Student's First Language" /><br>

                    <label>Address:</label>
                    <input type="text" class="form-control" v-model="studentData.address.city" placeholder="City" /><br>
                    <!-- <input type="text" class="form-control" v-model="studentData.address.state" placeholder="State" /><br> -->
                    <select v-model="studentData.address.state">
                        <option selected="selected" disabled>Select State</option>
                        <option v-for="state in stateList" :key="state.stateID" >{{state.stateName}}</option>
                    </select>
                    <input type="text" class="form-control" v-model="studentData.address.country" placeholder="Country" /><br>
                    <input type="text" class="form-control" v-model="studentData.address.pin" placeholder="Pincode" /><br>

                    <label>Father's Details:</label>
                    <input type="text" class="form-control" v-model="studentData.father.fatherName.firstName" placeholder="Father's First Name" /><br>
                    <input type="text" class="form-control" v-model="studentData.father.fatherName.middleName" placeholder="Father's Middle Name" /><br>
                    <input type="text" class="form-control" v-model="studentData.father.fatherName.lastName" placeholder="Father's Last Name" /><br>
                    <input type="email" class="form-control" v-model="studentData.father.email" placeholder="Father's Email" /> <br>
                    <input type="text" class="form-control" v-model="studentData.father.educationQualification" placeholder="Father's Education Qualification" /><br>
                    <input type="text" class="form-control" v-model="studentData.father.profession" placeholder="Father's Profession" /><br>
                    <input type="text" class="form-control" v-model="studentData.father.designation" placeholder="Father's Designation" /><br>
                    <input type="text" class="form-control" v-model="v$.studentData.father.phoneNumber.$model" placeholder="Father's Phone Number" /><br>
                    <p v-if="v$.studentData.father.phoneNumber.$error">Invalid Phone Number</p>

                    <label>Mother's Details:</label>
                    <input type="text" class="form-control" v-model="studentData.mother.motherName.firstName" placeholder="Mother's First Name" /><br>
                    <input type="text" class="form-control" v-model="studentData.mother.motherName.middleName" placeholder="Mother's Middle Name" /><br>
                    <input type="text" class="form-control" v-model="studentData.mother.motherName.lastName" placeholder="Mother's Last Name" /><br>
                    <input type="email" class="form-control" v-model="studentData.mother.email" placeholder="Mother's Email" /> <br>
                    <input type="text" class="form-control" v-model="studentData.mother.educationQualification" placeholder="Mother's Education Qualification" /><br>
                    <input type="text" class="form-control" v-model="studentData.mother.profession" placeholder="Mother's Profession" /><br>
                    <input type="text" class="form-control" v-model="studentData.mother.designation" placeholder="Mother's Designation" /><br>
                    <input type="text" class="form-control" v-model="v$.studentData.mother.phoneNumber.$model" placeholder="Mother's Phone Number" /><br>
                    <p v-if="v$.studentData.mother.phoneNumber.$error">Invalid Phone Number</p>

                    <label>Emergency Contacts:</label>
                    <div v-for="contact in studentData.emergencyContactArray" :key="contact">
                        <input type="text" class="form-control" placeholder="Relation with Student:" v-model="contact.relation"><br>
                        <input type="text" class="form-control" placeholder="Contact Number" v-model="contact.number"><br>
                    </div>

                    <label>Reference:</label>
                    <input type="text" class="form-control" v-model="studentData.reference.referenceDetails" placeholder="Reference Details" /><br>
                    <input type="text" class="form-control" v-model="studentData.reference.referenceThrough" placeholder="Reference Through" /><br>

                    <label>Reference Person Address:</label>
                    <input type="text" class="form-control" v-model="studentData.reference.address.city" placeholder="City" /><br>
                    <input type="text" class="form-control" v-model="studentData.reference.address.state" placeholder="State" /><br>
                    <input type="text" class="form-control" v-model="studentData.reference.address.country" placeholder="Country" /><br>
                    <input type="text" class="form-control" v-model="studentData.reference.address.pin" placeholder="Pincode" /><br>
                    <input type="text" class="form-control" v-model="studentData.reference.phoneNumber" placeholder="Phone Number" /><br>

                    <button type="submit" class="btn btn-success">Submit</button>

                    <button type="submit" class="btn btn-warning" @click.prevent="addEmergencyContact">Add Emergency Contact</button>
                </form>
            </div>
        </div>
        <div class="row my-2">
            <div class="col bg-dark text-white">
                <h1>Student Data Table</h1>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <table class="table table-striped table-hover">
                    <caption hidden>Student Data</caption>
                    <thead>
                        <tr >
                            <th>Name</th>
                            <th>Birthdate</th>
                            <th>Birthplace</th>
                            <th>First Language</th>
                            <th>Address</th>
                            <th>Father's Name</th>
                            <th>Father's Email</th>
                            <th>Father's Qualification</th>
                            <th>Father's Profession</th>
                            <th>Father's Designation</th>
                            <th>Father's Phone Number</th>
                            <th>Mother's Name</th>
                            <th>Mother's Email</th>
                            <th>Mother's Qualification</th>
                            <th>Mother's Profession</th>
                            <th>Mother's Designation</th>
                            <th>Mother's Phone Number</th>
                            <th>Emergency Contacts</th>
                            <th>Reference Details</th>
                            <th>Reference Through</th>
                            <th>Address</th>
                            <th>Contact Number</th>
                        </tr>
                    </thead>
                    <tbody v-for="student in arrStudent" :key="student.studentName.firstName">
                        <tr>
                            <td>{{student.studentName.firstName}} {{student.studentName.middleName}} {{student.studentName.lastName}}</td>
                            <td>{{student.dateOfBirth}}</td>
                            <td>{{student.placeOfBirth}}</td>
                            <td>{{student.firstLanguage}}</td>
                            <td>{{student.address.city}}, {{student.address.state}}, {{student.address.country}}, Pin: {{student.address.pin}}</td>
                            <td>{{student.fatherName.firstName}} {{student.fatherName.middleName}} {{student.fatherName.lastName}}</td>
                            <td>{{student.fatherEmail}}</td>
                            <td>{{student.fatherQualification}}</td>
                            <td>{{student.fatherProfession}}</td>
                            <td>{{student.fatherDesignation}}</td>
                            <td>{{student.fatherPhone}}</td>
                            <td>{{student.motherName.firstName}} {{student.motherName.middleName}} {{student.motherName.lastName}}</td>
                            <td>{{student.motherEmail}}</td>
                            <td>{{student.motherQualification}}</td>
                            <td>{{student.motherProfession}}</td>
                            <td>{{student.motherDesignation}}</td>
                            <td>{{student.motherPhone}}</td>
                            <td><div v-for="contact in student.emergencyContactArray" :key="contact"><p>{{contact.relation}}: {{contact.number}}</p></div></td>
                            <td>{{student.reference.referenceDetails}}</td>
                            <td>{{student.reference.referenceThrough}}</td>
                            <td>{{student.reference.address.city}}, {{student.reference.address.state}}, {{student.reference.address.country}}, {{student.reference.address.pin}}</td>
                            <td>{{student.reference.phoneNumber}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>

<script>
import useVuelidate from '@vuelidate/core'
import { required, email, numeric, minLength, maxLength } from '@vuelidate/validators'


export default {
    name:"StudentForm",
    setup () {
    return { v$: useVuelidate() }
  },

  data()
  {
    return{
        stateList:[{stateID:1,stateName:"Gujarat"},{stateID:2,stateName:"Maharashtra"},{stateID:3,stateName:"Rajasthan"}],
        arrStudent:[],
        studentData:{
                studentName:{
                firstName:"",
                middleName:"",
                lastName:""
            },
            dateOfBirth:"",
            placeOfBirth:"",
            firstLanguage:"",
            address:{
                city:"",
                state:"",
                country:"",
                pin:111111
            },
            father:{
                fatherName:{
                    firstName:"",
                    middleName:"",
                    lastName:""
                },
                email:"",
                educationQualification:"",
                profession:"",
                designation:"",
                phoneNumber:""
            },
            mother:{
                motherName:{
                    firstName:"",
                    middleName:"",
                    lastName:""
                },
                email:"",
                educationQualification:"",
                profession:"",
                designation:"",
                phoneNumber:""
            },
            emergencyContactArray:[
                {
                    relation:"",
                    number:""
                }
            ],
            reference:{
                referenceDetails:"",
                referenceThrough:"",
                address:{
                    city:"",
                    state:"",
                    country:"",
                    pin:111111
                },
                phoneNumber:""
            }
        },
    }
      
  },
  validations()
  {
      return{
          
        studentData:{
                studentName:{
                firstName:{ required },
                middleName:{ required },
                lastName:{ required }
            },
            dateOfBirth:{ required },
            placeOfBirth:{ required },
            firstLanguage:{ required },
            address:{
                city:{ required },
                state:{ required },
                country:{ required },
                pin:{ required }
            },
            father:{
                fatherName:{
                    firstName:{ required },
                    middleName:{ required },
                    lastName:{ required }
                },
                email:{ required, email },
                educationQualification:{ required },
                profession:{ required },
                designation:{ required },
                phoneNumber:{ required, numeric, minLength:minLength(10), maxLength:maxLength(10) }
            },
            mother:{
                motherName:{
                    firstName:{ required },
                    middleName:{ required },
                    lastName:{ required }
                },
                email:{ required, email },
                educationQualification:{ required },
                profession:{ required },
                designation:{ required },
                phoneNumber:{ required, numeric, minLength:minLength(10), maxLength:maxLength(10) }
            },
            reference:{
                referenceDetails:{ required },
                referenceThrough:{ required },
                address:{
                    city:{ required },
                    state:{ required },
                    country:{ required },
                    pin:{ required }
                },
                phoneNumber:{ required, numeric, minLength:minLength(10), maxLength:maxLength(10) }
            }
        }
    }
  },
  methods:
  {
      submit()
      {
				const result = this.v$.$validate();
				if(!result)
				{
					return;
				}
				if(this.studentData.studentName.firstName==""||this.studentData.studentName.middleName==""||this.studentData.studentName.lastName==""||this.studentData.dateOfBirth=="")
				{
					return;
				}
				else
				{
					let tempStudent = {
                        studentName:this.studentData.studentName,
                        dateOfBirth:this.studentData.dateOfBirth,
                        placeOfBirth:this.studentData.placeOfBirth,
                        firstLanguage:this.studentData.firstLanguage,
                        address:this.studentData.address,
                        fatherName:this.studentData.father.fatherName,
                        fatherEmail:this.studentData.father.email,
                        fatherQualification:this.studentData.father.educationQualification,
                        fatherProfession:this.studentData.father.profession,
                        fatherDesignation:this.studentData.father.designation,
                        fatherPhone:this.studentData.father.phoneNumber,
                        motherName:this.studentData.mother.motherName,
                        motherEmail:this.studentData.mother.email,
                        motherQualification:this.studentData.mother.educationQualification,
                        motherProfession:this.studentData.mother.profession,
                        motherDesignation:this.studentData.mother.designation,
                        motherPhone:this.studentData.mother.phoneNumber,
                        emergencyContactArray:this.studentData.emergencyContactArray,
                        reference:this.studentData.reference
                        };
					this.arrStudent.push(tempStudent);
					console.log(this.arrStudent);
				}
      },

      addEmergencyContact()
      {
				this.studentData.emergencyContactArray.push({relation:"",number:""});
      },

      
  }
    
}

</script>