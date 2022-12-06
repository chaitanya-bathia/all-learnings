CREATE DATABASE CarCompanyDB

CREATE TABLE Employees
(
	EmployeeID int PRIMARY KEY,
	EmployeeName varchar(50),
	JoiningDate date,
	Experience int,
	Commission int,
	NumberOfSales int
)

CREATE TABLE Inventory
(
	ModelID int PRIMARY KEY,
	ModelName varchar(50),
	CompanyName varchar(50),
	Color varchar(50),
	Price int,
	FuelType varchar(50),
	Stock int
)

CREATE TABLE Sales
(
	SaleID int,
	DateOfSale date,
	ModelID int FOREIGN KEY REFERENCES Inventory(ModelID),
	SoldThrough int FOREIGN KEY REFERENCES Employees(EmployeeID)
)
