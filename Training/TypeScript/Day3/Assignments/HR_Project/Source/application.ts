export class Application
{
    applicationID:number;
    applicantID:number;
    applicationDate:Date;
    applicationStatus:boolean;

    constructor(applicationID:number, applicantID:number,applicationDate:Date,applicationStatus:boolean)
    {
        this.applicationID=applicationID;
        this.applicantID=applicantID;
        this.applicationDate=applicationDate;
        this.applicationStatus=applicationStatus;
    }
}

let applicationArray:Array<Application> = [
    {applicationID:1,applicantID:3,applicationDate: new Date("2022-02-12"),applicationStatus:true},
    {applicationID:2,applicantID:1,applicationDate: new Date("2022-01-30"),applicationStatus:false}
]

function displayAllApplications()
{
    for (const i of applicationArray) {
        console.log(i);
    }
}

displayAllApplications();