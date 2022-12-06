const express = require('express');
const app = express();
const router = express.Router();
const port = 3001;
app.use(express.json());


router.use((req,res,next)=>{
    console.log(`${req.method} Request, ${req.url} URL`);
    next();
})

router.get('/user/:id',(req,res,next)=>{
    if(req.params.id === '0') next('route')
    // else{
    //     (req,res,next)=>{
    //         res.render('normal',(err)=>{
    //             if(err){
    //                 console.log(err);
    //             }});
    //         res.end()
    //     }
    // }
})

router.get('/user/:id', (req,res,next)=>{
    console.log(req.params.id);
    res.render('special', (err)=>{
        if(err){
            console.log(err);
        }
    });
    res.send()
    res.end();
    next();
})

app.use('/',router);


app.listen(port, ()=>{
    console.log("Server Running....")
})