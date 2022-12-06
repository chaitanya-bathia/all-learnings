
//Displaying Modules in sidebar(collapsing buttons)
function display_jquery_module1() {
    var x = document.getElementById("jquery-module1");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function display_jquery_module2() {
    var x = document.getElementById("jquery-module2");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//open practice & assignment list

//module1
function jquery1_practicelist() {
    var x = document.getElementById("jquery1-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function jquery1_assignmentlist() {
    var x = document.getElementById("jquery1-assignmentlist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

//module2
function jquery2_practicelist() {
    var x = document.getElementById("jquery2-practicelist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}

function jquery2_assignmentlist() {
    var x = document.getElementById("jquery2-assignmentlist");
    if (x.style.display === "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
}



//display result in main section

//Module 1
function jquery1_practice1()
{
    document.getElementById("jquery-mainSection").innerHTML='<object type="text/html" data="../Module 1/Practice/module1_practice1.html" height="100%" width="100%" ></object>'
}

function jquery1_assignment1()
{
    document.getElementById("jquery-mainSection").innerHTML='<object type="text/html" data="../Module 1/Assignment/module1_assignment1.html" height="100%" width="100%" ></object>'
}


//Module2
function jquery2_practice1()
{
    document.getElementById("jquery-mainSection").innerHTML='<object type="text/html" data="../Module 2/Practice/module2_practice.html" height="100%" width="100%" ></object>'
}

function jquery2_assignment1()
{
    document.getElementById("jquery-mainSection").innerHTML='<object type="text/html" data="../Module 2/Assignment/module2_assignment.html" height="100%" width="100%" ></object>'
}