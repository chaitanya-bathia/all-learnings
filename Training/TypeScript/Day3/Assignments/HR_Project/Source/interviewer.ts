import {Person} from './person';

export class Interviewer extends Person{
    interviewerID:number;
    interviewerPosition:string;

    constructor(id:number,name:string,address:string,qualification:string,position:string)
    {
        super(name,address,qualification);
        this.interviewerID=id;
        this.interviewerPosition = position;
    }
}

let interviewerArray : Array<Interviewer> = [
    {interviewerID:1,personName:"Ajay",personAddress:"Mumbai",personQualification:"MBA",interviewerPosition:"Senior HR"},
    {interviewerID:2,personName:"Mansi",personAddress:"Address",personQualification:"MBA", interviewerPosition:"Junior HR"}
]

function displayAllInterviewers()
{
    for (const i of interviewerArray) {
        console.log(i);
    }
}

displayAllInterviewers();