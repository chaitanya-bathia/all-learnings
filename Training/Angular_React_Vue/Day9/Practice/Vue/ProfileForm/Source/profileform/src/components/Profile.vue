<template>
    <div class="container-fluid">
        <div class="row">
            <div class="col bg-dark text-white">
                <h1>Profile Form</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-4 mx-auto my-3">
                <form @submit.prevent="submit()">
                    <input type="number" class="form-control" v-model="id" placeholder="Enter ID here." required><br>
                    <input type="text" class="form-control" v-model="profilename" placeholder="Enter Name here." required><br>
                    <input type="text" class="form-control" v-model="address" placeholder="Enter Address here." required><br>

                    <button class="btn btn-dark" type="submit">Submit</button>
                </form>
            </div>
        </div>

        <div class="row">
            <div class="col"><h1>Profiles List</h1></div>
        </div>
        <div class="row">
            <div class="col">
                <table class="table table-striped table-hover">
                    <caption hidden>Profile Table</caption>
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Address</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="profile in arrProfile" :key="profile.id">
                            <td>{{profile.id}}</td>
                            <td>{{profile.profilename}}</td>
                            <td>{{profile.address}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>

<script>

class Profile{
    id;
    profilename;
    address;

    constructor(id,profilename,address)
    {
        this.id=id;
        this.profilename=profilename;
        this.address=address;
    }
}

export default {
    name:"ProfileComponent",
    data()
    {
        return{
            id:0,
            profilename:"",
            address:"",
            arrProfile:[]
            
        }
    },
    methods:
    {
        submit()
        {
            if(this.id==0)
            {
                alert("ID is Invalid. Enter a valid ID.");
            }
            else if(this.profilename=="" )
            {
                alert("Name is Empty. Enter a name.");
            }
            else if(this.address=="")
            {
                alert("Address is Empty. Enter your Address.");
            }
            else
            {
                this.arrProfile.push(new Profile(this.id,this.profilename,this.address));
            }
            
        }
    }
}


</script>