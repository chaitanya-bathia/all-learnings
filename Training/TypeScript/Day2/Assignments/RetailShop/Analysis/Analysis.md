1. an interface for items is created, that will make a basic layout for items in the store.
2. a class for product is made which implements the item interface, meaning the variables declared in the items interface will be available for use to the product class
3. these attributes are then initialized using constructor
4. purchase method is created in the class and quantity of purchase is given as parameter. This method first checks the available quantity of the product and if it is more than 5, the order quantity is subtracted from the product's available quantity. Else it raises a reorder request.
5. a check quantity method is created, that returns true if quantity of given item is more than 5, else returns false.

6. checker will get user input for choice of what user wants to do.
7. If the user picks to place an order, then user is asked for a product ID for which they want to place the order.
8. for a valid product ID, the user is then asked to enter the quantity they want to order
9. from here the check quantity method for that product ID will be called and steps written above will be executed.
10. if user chooses to see the quantity of all products, it will be displayed accordingly
11. if the user chooses to exit, the quantity of all products will be displayed once and then the application will close.