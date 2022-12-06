import { arrayGuests } from "./guest";
import { rentArray } from "./rent";
import { Guest } from "./guest";
import { Rent } from "./rent";

type Merged  = Guest & Rent;

const mergeArrays = (guests: Guest[], rent: Rent[]): Merged[] => {
    return guests.map((guest, i) => {
        return {
            ...guest,
            ...rent[i],
        };
    });
};

export let mergedArray = mergeArrays(arrayGuests,rentArray);

export function report()
{    
    for (const i of mergedArray) {
        console.log(`Full Name: ${i.firstName}  ${i.lastName}, City: ${i.city}, State: ${i.state}, Type Of Room: ${i.typeOfRoom}, Amount: ${i.amount}`);
    }
}
