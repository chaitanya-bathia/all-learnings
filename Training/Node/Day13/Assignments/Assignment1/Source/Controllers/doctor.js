const mongoose = require('mongoose');
const express = require('express');
const router = express.Router();
const app = express();

app.use(express.json());

const doctorModel = require('../Models/Doctor');

// router.get("/",(req,res)=>{
//     doctorModel.find((err,data)=>{
//         res.send(data);
//         res.end();
//     })
// })


// get all details
router.get("/", async (req, res) => {
    var data = await doctorModel.find().populate("patients.patientId", "firstName");
    res.send(data);
    res.end();
})

// get patient report
router.get("/getreport", async (req, res) => {
    var doctor = await doctorModel.findById(req.body._id);
    res.send(doctor.patients);
    res.end();
});




// add new doctor
router.post("/", (req, res) => {
    var doctor = new doctorModel(req.body);
    doctor.save();
    res.send(doctor);
    res.end();
})


// delete doctor
router.delete("/delete", (req, res) => {
    doctorModel.deleteOne({ _id: req.body._id }, () => { console.log("Doctor Data Deleted") });
    res.send("Doctor Data Deleted.");
    res.end();
});


// update doctor
router.put("/update", (req, res) => {
    doctorModel.updateOne({ _id: req.body._id }, req.body, () => { console.log("Doctor Data updated.") });
    res.send("Doctor data updated");
    res.end();
})


// add patient to existing doctor
router.put("/update/addPatient", async (req, res) => {
    let tempDoc = await doctorModel.findById(req.body._id);
    tempDoc.patients.push({ "patientId": req.body.patientId });
    tempDoc.save();
    res.send("Patient Added");
    res.end();
})

module.exports = router