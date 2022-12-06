const fs= require('fs');

function main(){

    setTimeout(()=>console.log("1"),0);

    setImmediate(()=>console.log("2"));

    fs.readFile('./demoFile.txt', (err, data)=>{

        setTimeout(()=>{

            console.log("3");

        },1000);

        process.nextTick(()=>{

            console.log("next process");

        });

        setImmediate(()=>console.log("4"));

        setImmediate(()=>console.log("5"));

        setTimeout(()=>{

            process.on('exit', (code)=>{

                console.log("close callback");

            })

        },1100);



    })

}

main();