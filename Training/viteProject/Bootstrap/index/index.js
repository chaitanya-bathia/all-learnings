
//Displaying Modules in sidebar(collapsing buttons)
function display_bs_module1() {
    var x = document.getElementById("bs-module1");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function display_bs_module2() {
    var x = document.getElementById("bs-module2");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function display_bs_module3() {
    var x = document.getElementById("bs-module3");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function display_bs_module4() {
    var x = document.getElementById("bs-module4");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//open practice & assignment list

//module1
function bs1_practicelist() {
    var x = document.getElementById("bs1-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//module2
function bs2_practicelist() {
    var x = document.getElementById("bs2-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function bs2_assignmentlist() {
    var x = document.getElementById("bs2-assignmentlist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//module3
function bs3_practicelist() {
    var x = document.getElementById("bs3-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//module4
function bs4_practicelist() {
    var x = document.getElementById("bs4-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}


//display result in main section

//Module 1
function bs1_practice1()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 1/Practice/BootstrapPractice.html" height="100%" width="100%" ></object>'
}

//Module2
function bs2_practice1()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 2/Practice/Module2_Practice.html" height="100%" width="100%" ></object>'
}

function bs2_assignment1()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 2/Assignment/BootstrapResume.html" height="100%" width="100%" ></object>'
}

//Module3

function bs3_practice1()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 3/LoopLab/src/index.html" height="100%" width="100%" ></object>'
}
function bs3_practice2()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 3/Rembrandt Project/rembrandt.html" height="100%" width="100%" ></object>'
}

//Module 4

function bs4_practice1()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 5/Admin Panel/src/login.html" height="100%" width="100%" ></object>'
}
function bs4_practice2()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Module 5/Mizuxe/src/index.html" height="100%" width="100%" ></object>'
}

//Extra Udemy

function bs_extra()
{
    document.getElementById("bs-mainSection").innerHTML='<object type="text/html" data="../Udemy Project/index.html" height="100%" width="100%" ></object>'
}