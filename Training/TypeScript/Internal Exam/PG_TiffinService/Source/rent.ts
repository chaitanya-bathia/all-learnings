import { arrayGuests } from "./guest";

export class Rent
{
    guestID:number;
    amount:number;
    dateOfPayment: (Date | string);
}

export let rentArray : Array<Rent>= [
    {guestID:1,amount:0,dateOfPayment:new Date("2022-03-01")},
    {guestID:2,amount:0,dateOfPayment:new Date("2022-03-01")},
    {guestID:3,amount:0,dateOfPayment:new Date("2022-03-01")},
    {guestID:4,amount:0,dateOfPayment:new Date("2022-03-01")},
    {guestID:5,amount:0,dateOfPayment:new Date("2022-03-01")},
]

for(let x=0;x<rentArray.length;x++)
{
    if(rentArray[x].guestID==arrayGuests[x].guestID)
    {
        if(arrayGuests[x].typeOfRoom=="AC")
        {
            rentArray[x].amount=10000;
        }
        else if(arrayGuests[x].typeOfRoom=="NonAC")
        {
            rentArray[x].amount=8000;
        }
    }
}

function displayRent()
{
    for (const i of rentArray) {
        console.log(i);
    }
}

displayRent();

export function currentMonthCollection()
{
    let monthSum=0;
    for (const i of rentArray) {
        monthSum+=i.amount;
    }
    console.log("This Month's collection is:"+monthSum);
}

export function currentYearCollection()
{
    
    let yearSum=0;
    let currentMonth = new Date().getMonth();
    while(currentMonth != 0)
    {
        for (const i of rentArray) {
            yearSum+=i.amount;
        }
        currentMonth--;
    }

    console.log("This year's collection so far is:" +yearSum);
}

