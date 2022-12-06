export class Vacancy
{
    vacancyID:number;
    vacancyCategory:string;
    vacancyAmount:number;

    constructor(id:number,category:string,amount:number)
    {
        this.vacancyID = id;
        this.vacancyCategory=category;
        this.vacancyAmount=amount;
    }
}

let vacancyArray:Array<Vacancy> = [
    {vacancyID:1,vacancyCategory:".NET",vacancyAmount:20},
    {vacancyID:2,vacancyCategory:"PHP",vacancyAmount:5},
    {vacancyID:3,vacancyCategory:"Management",vacancyAmount:5},
    {vacancyID:4,vacancyCategory:"NodeJS",vacancyAmount:10}
]


displayAllVacancies();

function displayAllVacancies()
{
    for (const i of vacancyArray) {
        console.log(i);
    }
}