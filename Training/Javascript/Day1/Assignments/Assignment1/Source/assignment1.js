

function calculate() {
    if (document.getElementById("num1").value == "") {
        alert("Please Enter number 1.")
    }

    if (document.getElementById("num2").value == "") {
        alert("Please Enter number 2.")
    }
    else {
        var x = parseInt(document.getElementById("num1").value);
        var y = parseInt(document.getElementById("num2").value);

        var op = document.querySelector('input[name="operation"]:checked').id;

        switch (op) {
            case 'addition':
                {
                    document.getElementById("result").innerHTML += x + y;
                    break;
                }
            case 'subtraction':
                {
                    document.getElementById("result").innerHTML += x - y;
                    break;
                }
            case 'multiplication':
                {
                    document.getElementById("result").innerHTML += x * y;
                    break;
                }
            case 'division':
                {
                    document.getElementById("result").innerHTML += x / y;
                    break;
                }
            default:
                {
                    document.getElementById("result").innerHTML = "Invalid Choice";
                    break;
                }
        }
    }

}
function reset() {
    document.getElementById("form1").reset();
}