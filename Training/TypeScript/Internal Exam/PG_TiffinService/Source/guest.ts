enum roomType
{
    AC = "AC",
    NonAC = "NonAC"
}

interface Renter
{
    guestID:number;
    firstName:string;
    lastName:string;
    panCardNumber:string;
    address:string;
    city:string;
    state:string;
    typeOfRoom: string;
}

export class Guest implements Renter
{
    guestID: number;
    firstName: string;
    lastName: string;
    panCardNumber: string;
    address: string;
    city: string;
    state: string;
    typeOfRoom: string;
    

    constructor(guestID:number,firstName:string,lastName:string,panCardNumber:string,address:string,city:string,state:string,typeOfRoom:string)
    {
        this.guestID=guestID;
        this.firstName=firstName;
        this.lastName=lastName;
        this.panCardNumber=panCardNumber;
        this.address=address;
        this.city=city;
        this.state=state;
        this.typeOfRoom=typeOfRoom;
    }
}

export let arrayGuests:  Array<Guest> = [
    {guestID:1,firstName:"Jay",lastName:"Shetty",panCardNumber:"FSDDE2235A",address:"150ft Ring Road",city:"Rajkot",state:"Gujarat", typeOfRoom: roomType.AC},
    {guestID:2,firstName:"Pooja",lastName:"Mehta", panCardNumber:"FDSSQ5464J", address:"Bopal",city:"Ahmedabad",state:"Gujaray",typeOfRoom:roomType.NonAC},
    {guestID:3,firstName:"Rahul",lastName:"Joshi", panCardNumber:"ERTEQ2316H", address:"Thaltej",city:"Ahmedabad",state:"Gujarat",typeOfRoom:roomType.AC},
    {guestID:4,firstName:"Komal",lastName:"Kaushik", panCardNumber:"VBCCK7418Q", address:"Vasai",city:"Mumbai",state:"Gujarat",typeOfRoom:roomType.AC},
    {guestID:5,firstName:"Raj",lastName:"Khatri", panCardNumber:"KOILE5951B", address:"Connaught Place",city:"Delhi",state:"Delhi",typeOfRoom:roomType.NonAC}
]


export function inGujarat()
{
    console.log("Guests in Gujarat:");
    for (const i of arrayGuests) {
        if(i.state=="Gujarat")
        {
            console.log(i);
        }
    }
}

export function gujaratAndAC()
{
    console.log("Guests in Gujarat, living in AC rooms:");
    for (const i of arrayGuests) {
        if(i.state=="Gujarat" && i.typeOfRoom=="AC")
        {
            console.log(i);
        }
    }
}