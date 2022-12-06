class Employee
{
    ID:number;
    Name:string;
    City:string;
    DOJ:Date;

    constructor(id:number,name:string,city:string,doj:Date)
    {
        this.ID=id;
        this.Name=name;
        this.City=city;
        this.DOJ=doj;
    }
}

let employeeArray:Array<Employee> = [
    {ID:1,Name:"Sumit",City:"Ahmedabad",DOJ: new Date("2021-02-15")},
    {ID:2,Name:"Kiran",City:"Surat",DOJ: new Date("208-05-01")},
    {ID:3,Name:"Mohit",City:"Mumbai",DOJ: new Date("2022-01-20")}
]

function searchAfter2020()
{
    for (const emp of employeeArray) {
        if(emp.DOJ.getFullYear()> 2020)
        {
            console.log(emp);
        }
    }
}

searchAfter2020();


function searchMumbai2020()
{
    for (const emp of employeeArray) {
        if(emp.DOJ.getFullYear()> 2020 &&  emp.City=="Mumbai")
        {
            console.log(emp);
        }
    }
}

searchMumbai2020();