var x = parseInt(prompt("Enter number1:"));
var y = parseInt(prompt("Enter number2:"));
var z = parseInt(prompt("Enter number3:"));
var sum=0;

if (x > y) 
{
    if (x > z) 
    {
        document.getElementById("result").innerHTML += x;
    }
    else 
    {
        document.getElementById("result").innerHTML += z;
    }
}
else 
{
    if (y > z) 
    {
        document.getElementById("result").innerHTML += y;
    }
    else 
    {
        document.getElementById("result").innerHTML += z;
    }
}

if(x>40)
{
    sum+=x;
}

if(y>40)
{
    sum+=y;
}

if(z>40)
{
    sum+=z;
}

document.getElementById("sum").innerHTML += sum;