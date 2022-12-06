export class Interview
{
    interviewID:number;
    interviewDate:Date;
    applicationID:number;
    interviewerID:number;

    constructor(interviewID:number,interviewDate:Date,applicationID:number,interviewerID:number)
    {
        this.interviewID=interviewID;
        this.interviewDate=interviewDate;
        this.applicationID=applicationID;
        this.interviewerID=interviewerID;
    }
}

let interviewArray :Array<Interview> = [
    {interviewID:1,interviewDate: new Date("2022-03-05"),applicationID:1,interviewerID:2},
    {interviewID:2,interviewDate: new Date("2022-03-15"),applicationID:2,interviewerID:1}
]

function addInterview()
{
    interviewArray.push(new Interview(3,new Date("2022-03-30"),2,2))
}

addInterview();

function displayAllInterviews()
{
    for (const i of interviewArray) {
        console.log(i);
    }
}

displayAllInterviews();