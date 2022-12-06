const express = require('express');
const fs = require('fs');
const app = express();

const router = express.Router();

app.use(express.json());


app.get("/",(req,res)=>{
    fs.readFile('./customer.json',(err,data)=>{
        if(err)
        {
            console.log(err);
            return;
        }
        console.log(JSON.parse(data));
        res.send(data);
        res.end();
    })
})

app.post("/addcustomer",(req,res)=>{
    var customers = [];
    fs.readFile("./customer.json","utf-8",(err,data)=>{
        customers = JSON.parse(data);

        customers.push(req.body);

        fs.writeFile("./customer.json",JSON.stringify(customers),(err)=>{
            if(err){
                console.log(err);
                return;
            }
            res.send("Data added successfully.");
            res.end();
        })
    })
})

app.put("/editCustomer/:id",(req,res)=>{
    var customers =[];
    fs.readFile("./customer.json","utf-8",(err,data)=>{
        customers = JSON.parse(data);

        var result = customers.find((data)=>{
            return data.id == req.params.id;
        })

        result.name = req.body.name;

        fs.writeFile("./customer.json",JSON.stringify(customers),(err)=>{
            if(err){
                console.log(err);
                return;
            }
            res.send("Data updated successfully.");
            res.end();
        })
    })
})

app.delete("/delete/:id",(req,res)=>{
    var customers =[];
    var tempArray = [];
    fs.readFile("./customer.json","utf-8",(err,data)=>{
        customers = JSON.parse(data);

        customers.splice(req.params.id-1,1);
        // var result = customers.find((data)=>{
        //     return data.id == req.params.id;
        // })

        // for(let i = customers.length-1;i!=result.id-1;i--){
        //     tempArray.push(customers.pop());
        // }

        // customers.pop();
        // while(tempArray.length>0){
        //     customers.push(tempArray.pop());
        // }

        fs.writeFile("./customer.json",JSON.stringify(customers),(err)=>
        {
            res.send(customers);
            res.end();
        })
    })
})

app.listen(3001,()=>{
    console.log("Server Running....")
})