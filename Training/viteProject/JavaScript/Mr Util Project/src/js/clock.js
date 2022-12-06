function openSidePanel()
{
    document.getElementById("sidePanel").style.width = "250px";
}

function closeSidePanel()
{
    document.getElementById("sidePanel").style.width = "0px";
}

var outtime = document.getElementById("outtime");

setInterval(() => {
    gettime()
}, 1000);

function gettime()
{
    let currentTime = new Date();

    let hour= currentTime.getHours();
    let min= currentTime.getMinutes();
    let sec= currentTime.getSeconds();
    let ampm = "AM"
    
    if(currentTime.getHours() >12)
    {
        hour-=12;
        ampm = "PM";
    }

    if(hour<10)
    {
        hour= '0'+ hour.toString()
    }

    if(min<10)
    {
        min= '0'+ min.toString()
    }

    if(sec<10)
    {
        sec= '0'+ sec.toString()
    }


    outtime.innerHTML = `${hour} : ${min} : ${sec} ${ampm}`;
}