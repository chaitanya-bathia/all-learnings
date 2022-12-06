let express = require('express');
let fs = require('fs');
let port= 3000;
const router= express.Router();
let app= express();
app.use(express.json());


router.get('/employees', (req, res) => {
    var emp = [];
    fs.readFile('./employee.json', (err, data) => {
      if (err) {
        console.log(err);
      } else {
        emp = JSON.parse(data);
        res.send(data);
      }
    });
  });
router.get('/employees/:id', (req,res)=>{
    fs.readFile('./employee.json', (err,data)=>{
        const emp=JSON.parse(data);
        const result= emp.find((data1)=>{
            return data1.id==parseInt(req.params.id);
        })
        res.send(result);
        console.log(result);
    })
})
router.get('/employees/:id/child/assignments', (req,res)=>{
    fs.readFile('./employee.json', (err,data)=>{
        if(err){
            console.log(err);
        }
        var emp=[];
        emp= JSON.parse(data);
        var result= emp.find((data1)=>{
            return data1.id==parseInt(req.params.id);
        })
        console.log(result.assignments);
        res.send(result.assignments);
    })
})
router.get('/employees/:id/child/assignments/:AssignmentID', (req,res)=>{
    fs.readFile('./employee.json', (err, data)=>{
    var emp=[];
    emp=JSON.parse(data);
    var findemp=emp.find((data1)=>{
        return data1.id==parseInt(req.params.id);
    })
    const assignId=findemp.assignments.find((data)=>{
        if(at.AssignmentId==parseInt(req.params.assign)){
            return findemp.assignments;
        }
    })
    res.send(assignId);
    })
})
router.post('/employees', (req, res)=>{
    data1=[];
    fs.readFile('./employee', "utf-8", (err,data)=>{
        data1=JSON.parse(data);
        data1.push(req.body);
        fs.writeFile('./employee.json', JSON.stringify(data1), (err)=>{
            console.log("written");
        })
        res.send(data1);
        res.end();
    })
})
router.put('/employees/:id/child/assignments/:assignmentId', (req,res)=>{
    var emp=[];
    fs.readFile('./employee.json', "utf-8", (err,data)=>{
        if(err){
            console.log(err);
        }
        else{
            emp=JSON.parse(data);
            var matched= emp.find((data)=>{
                return req.params.id==employee.id;
            })
            if(matched==-1){
                res.send("PLEASE ENTER VALID EMPLOYEE ID");
            }
            else{
                var empAssign=emp[matched].assignments;
                var matchedAssignment= empAssign.find((assign)=>{
                    return req.params.AssignmentId;
                })
                if(matchedAssignment==-1){
                    res.send("PLEASE ENTER VALID ASSIGNMENT ID");
                }
                else{
                    emp[matched].assignments[matchedAssignment]=req.body;
                    fs.writeFile('./employee.json', JSON.stringify(emp), (err)=>{
                        if(err){
                            console.log(err);
                        }
                        else{
                            console.log(`Updated Assignment ${req.params.assignmentId} for employee ${req.params.id}`);
                        }
                    })
                }
            }
        }
    })
})
app.listen(port, ()=>{
    console.log("server started");
})



app.use('/', router);