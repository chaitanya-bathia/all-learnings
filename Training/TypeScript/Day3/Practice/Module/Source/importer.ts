import {adder} from './exporter';
import {productInterface} from './exporter';
let demoAdder = new adder(5,10);

console.log(demoAdder.add());


class Product implements productInterface
{
    productID: number;
    productName: string;
    productPrice: number;
    
    constructor(id:number,name:string,price:number)
    {
        this.productID = id;
        this.productName=name;
        this.productPrice=price;
    }

    displayProduct()
    {
        console.log(`ID: ${this.productID}, Name: ${this.productName}, Price: ${this.productPrice}`);
    }
}

let chocolate = new Product(1,"Chocolate", 100);
chocolate.displayProduct();
