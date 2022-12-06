import { Person } from "./person";

export class Applicant extends Person
{
    applicantID: number;
    applicationCategory: string;

    
    constructor(id:number,name:string,address:string,qualification:string,applicationCategory:string)
    {
        super(name,address,qualification);
        this.applicantID = id;
        this.applicationCategory= applicationCategory;
    }
}

let applicantArray :Array<Applicant> = [
    {applicantID:1,personName:"Raj",personAddress:"Ahmedabad",personQualification:"B.Tech",applicationCategory:".NET"},
    {applicantID:2,personName:"Pooja",personAddress:"Baroda",personQualification:"MCA",applicationCategory:"PHP"},
    {applicantID:3,personName:"Jeet",personAddress:"Ahmedabad",personQualification:"MBA",applicationCategory:"Management"}
]

displayAllApplicants();

function displayAllApplicants()
{
    for (const i of applicantArray) {
        console.log(i);
    }
}

let searchID:number=2;
displayApplicantById(searchID);

function displayApplicantById(searchID)
{
    for (const i of applicantArray) {
        if(i.applicantID == searchID)
        {
            console.log(i);
        }
    }
}

let newApplicant = new Applicant(5,"Arun","Ahmedabad","MCA","NodeJS");

function addApplicant(newApplicant:Applicant)
{
    applicantArray.push(newApplicant);
}

addApplicant(newApplicant);

displayAllApplicants();