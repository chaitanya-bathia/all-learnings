// console.log("Hello Everyone");
// console.log("New Auto");

var args = process.argv;

const fs = require('fs');

fs.appendFile('./person.txt',' \nHello India', (err)=>
{
    if(err)
    {
        console.log(err);
        return;
    }
})

fs.appendFile('./person.txt',` \nHello ${args[2]}`, (err)=>
{
    if(err)
    {
        console.log(err);
        return;
    }
})

readFile('./person.txt');

function readFile(filename)
{
    fs.readFile(filename, 'utf-8', (err,data)=>{
        if(err){
            console.log(err);
            return;
        }
        console.log(data);
    })
}

async function readBoth(){
    await readFile('./one.txt');
    await readFile('./two.txt');
}

readBoth();

//Address

fs.writeFile('./address.txt','502, Soham Plaza, Panchvati Society, Jamnagar',(err) =>{if(err){console.log(err)}});

var address = "";
fs.readFile('./address.txt','utf-8',(err,data)=>
{
    if(err)
    {
        console.log(err);
        return;
    }
    address=data;
    let consonantCounter = 0;
    for(let i = 0;i<address.length;i++)
    {
        if(address.charAt(i)=='a'||address.charAt(i)=='A'||address.charAt(i)=='e'||address.charAt(i)=='E'||address.charAt(i)=='i'||address.charAt(i)=='I'
        ||address.charAt(i)=='o'||address.charAt(i)=='O'||address.charAt(i)=='u'||address.charAt(i)=='U'||address.charAt(i)=='1'||address.charAt(i)=='2'
        ||address.charAt(i)=='3'||address.charAt(i)=='4'||address.charAt(i)=='5'||address.charAt(i)=='6'||address.charAt(i)=='7'||address.charAt(i)=='8'
        ||address.charAt(i)=='9'||address.charAt(i)=='0'||address.charAt(i)==' '||address.charAt(i)==',')
        {
            continue;
        }
        else{
            consonantCounter++;
        }
    }
    console.log(`${consonantCounter} Consonants in address`);
});


fs.mkdir('./TestFolder',(err)=>{if(err){console.log(err)}});

fs.copyFile('./person.txt','./TestFolder/person.txt',(err)=>{if(err){console.log(err)}});
