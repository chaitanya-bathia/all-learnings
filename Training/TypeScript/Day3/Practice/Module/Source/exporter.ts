export class adder{
    num1:number;
    num2:number;

    constructor(num1:number,num2:number)
    {
        this.num1=num1;
        this.num2=num2;
    }

    add()
    {
        return this.num1+this.num2;
    }
}

export interface productInterface
{
    productID:number;
    productName:string;
    productPrice:number;

    displayProduct();
}