function validateLogin()
{
    if($("#txtusername").val()=="")
    {
        sweetAlert("empty Username","","warning");
    }
    
    else if($("#txtpassword").val()=="")
    {
        sweetAlert("empty password","","warning");
    }

    else
    {
        location.replace("../html/home.html");
    }
}