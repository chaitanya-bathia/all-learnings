1. This angular app will contain 3 main components, Login, Signup and Rectangle.
2. The login component will initially take two fields as input from the user, namely username and password.
3. These fields are then stored into two variables using two-way data binding, and then validated.
4. The validation will check if username and password have value "admin". If yes, User is alerted that login is successful.
5. If one or both fields are not "admin", then user is prompted that credentials are invalid.
6. As for the signup component, it accepts user details such as Name, Address and PAN Number from the user.
7. These fields are then stored into variables using two-way data binding.
8. Once user finishes entering the details, these data will be interpolated into a paragraph, showing the user what data they entered.
9. The Rectangle component is designed to take two inputs from user, namely Height and width.
10. These fields are then stored into two variables using two-way data binding.
11. The area of rectangle is then computed and the result is stored into a variable, and interpolated and displayed to user.
12. All these components are called into the app component and made available to the user for interaction.