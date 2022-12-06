var args = process.argv;

var choice = parseInt(args[2]);

var num1 = parseInt(args[3]);
var num2 = parseInt(args[4]);

let fs = require('fs');

switch (choice) {
    case 1:
        {add(num1,num2);
        break;}

    case 2:
        {sub(num1,num2);
        break;}
    case 3:
        {mul(num1,num2);
        break;}
    case 4:
       { div(num1,num2);
        break;}

    default:
        console.log("Invalid Input");
        break;
}

function add(num1,num2)
{
    fs.writeFile('./answer.txt',(num1+num2).toString(),(err)=>{if(err){console.log(err)}});
}

function sub(num1,num2)
{
    fs.writeFile('./answer.txt',(num1-num2).toString(),(err)=>{if(err){console.log(err)}});
}

function mul(num1,num2)
{
    fs.writeFile('./answer.txt',(num1*num2).toString(),(err)=>{if(err){console.log(err)}});
}

function div(num1,num2)
{
    fs.writeFile('./answer.txt',(num1/num2).toString(),(err)=>{if(err){console.log(err)}});
}

function getSolution()
{
    fs.readFile('./answer.txt','utf-8', (err,data)=>{
        if(err)
        {
            console.log(err);
            return;
        }
        console.log(data.toString());
    })
}

getSolution();