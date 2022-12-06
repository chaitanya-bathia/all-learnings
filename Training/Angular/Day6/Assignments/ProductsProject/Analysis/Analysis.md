1. The parent component(product-component) holds 3 input fields for user to enter data, namely Product name, Price and Quantity.
2. Once the user enters the data and adds product, the data is stored into an object called Product.
3. This product object is then pushed into an array made to store the product objects.
4. Before pushing into the array, the 5% discount is computed on the price of the product entered.
5. After every entry, the array of product objects is sent to the child component, namely Product-list.
6. The product list component accepts the array of objects as input and stores it into a local array.
7. This data is then displayed using interpolation and iterating over a collection, into a table.