interface item{
    productID:number;
    productName:string;
    quantity:number;
}
class Product implements item{
    productID:number;
    productName:string;
    quantity: number;
    constructor(id,name,q){
        this.productID=id;
        this.productName=name;
        this.quantity=q;
    }
    purchase(a){
        if(this.checkQuantity()==true){
            this.quantity=this.quantity-a;
            console.log('\norder place');
        }else{
            console.log('\npls reorder');
        }
    }
    checkQuantity(){
        if(this.quantity<=5){
            return false;
        }else{
            return true;
        }
    }
    printQuantity(){
        console.log('\nproduct id:'+this.productID+'\nProduct Name:'+this.productName+'\nno of quantity available is:'+this.quantity);
    }
}
const readline = require('readline');
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});


var p1=new Product(1,'Book',50);
var p2=new Product(2,'Bag',20);
var p3=new Product(3,'Pen',40);

var productArr=[p1,p2,p3];
checker();


function checker(){
    console.log(productArr);
    rl.question("\nEnter choice : \n 1.Place order \n 2.Print Quanity \n 3.Close", function (ch) 
    {
        if(ch==1)
        {
            rl.question("Please Enter productID ", function (id : any)
            {
                rl.question("Please Enter quantity for order: ", function (qun :any)
                {
                    for(let i=0;i<productArr.length;i++)
                    {
                        if(parseInt(id)==productArr[i].productID)
                        {
                            productArr[i].purchase(parseInt(qun));
                            productArr[i].printQuantity();
                            checker();
                        }
                    }
                })
            })
        }
        
        else if(ch==2)
        {
            for(let i=0;i<productArr.length;i++)
            {
                productArr[i].printQuantity();
            }
            checker();
        }
        else if(ch==3)
        {
            rl.close();
        }
    })
}