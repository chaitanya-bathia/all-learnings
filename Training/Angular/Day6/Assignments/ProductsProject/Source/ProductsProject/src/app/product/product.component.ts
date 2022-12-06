import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  objProduct = { productName: "", price: 0, quantity: 0 }

  arrProducts: any = []

  addProduct() {
    if (this.objProduct.productName == "" || this.objProduct.price == 0 || this.objProduct.quantity == 0) {
      alert("Invalid Entry. Try Again.");
    }
    else {
      this.objProduct.price =this.objProduct.price-(this.objProduct.price*0.05);
      this.arrProducts.push(this.objProduct);
      
    }
  }
  resetFields() {
    this.objProduct.productName = '';
    this.objProduct.price = 0;
    this.objProduct.quantity = 0;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
