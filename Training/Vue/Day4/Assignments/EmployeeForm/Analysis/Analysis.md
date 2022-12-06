1. Employee details are entered by user, such as fields like EmployeeID, EmployeeName, Gender, Date of joining, and Hobbies
2. Two way binding is used to bind these fields to variables created in the component.
3. The variables are used to populate an object, which holds all entered data.
4. When user enters all the data, it then stored in an object, which is later pushed into an array.
5. Once the entire array is populated, all the details are then displayed into a table.
6. Also, this array is sorted based on the name field of the employee objects.
7. There is another button added for filtering the Employees that have joined in the recent times, specifically the current month.
8. The joining date's month of each employee is compared with the current Date's month, to check which employee joined in this month.
9. When the user clicks the filter button, all the employees that have joined in the current month will be displayed.