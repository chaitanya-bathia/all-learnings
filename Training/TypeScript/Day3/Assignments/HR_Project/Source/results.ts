export class Results
{
    resultID:number;
    interviewID:number;
    interviewResult:boolean;

    constructor(resultID:number,interviewID:number,interviewResult:boolean)
    {
        this.resultID=resultID;
        this.interviewID=interviewID;
        this.interviewResult=interviewResult;
    }
}

let resultArray :Array<Results> = [
    {resultID:1,interviewID:1,interviewResult:true},
    {resultID:2,interviewID:2,interviewResult:false}
]

function displayResults()
{
    for (const i of resultArray) {
        console.log(i);
    }
}

displayResults();
