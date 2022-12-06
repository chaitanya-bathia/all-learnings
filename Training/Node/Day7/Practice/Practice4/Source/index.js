const express = require('express');
const fs = require('fs');
const app = express();
const port = 3001;

const router = express.Router();

app.use(express.json());

router.get('/employee', (req, res) => {
    fs.readFile('./employee.json', "utf-8", (err, data) => {
        if (err) {
            console.log(err);
        }
        res.send(JSON.parse(data));
    })
})

router.get('/employee/:id', (req, res) => {
    fs.readFile('./employee.json', "utf-8", (err, data) => {
        if (err) {
            console.log(err);
            return;
        }
        let data1 = JSON.parse(data);
        var result = data1.find((data) => {
            return (data.id == req.params.id)
        })
        res.send(JSON.stringify(result));
    })
})

router.post('/employee/post',(req,res)=>{
    let data1=[];
    fs.readFile('./employee.json',"utf-8",(err,data)=>{
        data1 = JSON.parse(data);
        data1.push(req.body);
        console.log(req.body);
        fs.writeFile('./employee.json',JSON.stringify(data1),(err)=>{
            console.log("file written");
        })

        res.send(data1);
        res.end();
    })
})

router.put('/employee/update/:id',(req,res)=>{
    let data1=[];
    fs.readFile('./employee.json',"utf-8",(err,data)=>{
        data1=JSON.parse(data);
        const result = data1.find((data)=>{
            return data.id==req.params.id;
        })

        

        result.FirstName = req.body.FirstName;

        fs.writeFile('./employee.json',JSON.stringify(data1),(err)=>{
            console.log("Name Updated");
        })
        res.send(data1);
        res.end();
    })
})


app.listen(port, () => {
    console.log(`server running at ${port}`);
})

app.use('/', router);