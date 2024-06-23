--01. Create Database
CREATE DATABASE Minions
USE Minions
GO	
--02. Create Tables
CREATE TABLE Minions
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50),
	Age INT
)
CREATE TABLE Towns
(
	id INT PRIMARY KEY,
	[Name] VARCHAR(50)
)
-- 03. Alter Minions Table
--Option1
ALTER TABLE Minions
ADD  TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(id)

--Option2 ALTER TABLE Minions
--ADD TownId INT FOREIGN KEY (TownId) REFERENCES Towns(id)

-- 04. Insert Records in Both Tables


INSERT INTO Towns	
VALUES
	(1,'Sofia'),
	(2,'Plovdiv'),
	(3,'Varna')

INSERT INTO Minions(Id, [Name], Age, TownId)
VALUES
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2)
	
SELECT * FROM Minions
JOIN Towns on Towns.id = Minions.TownId
SELECT * FROM Towns

--05. Truncate Table Minions
TRUNCATE TABLE Minions
SELECT * FROM Minions

--06. Drop Tables
DROP TABLE Minions
DROP TABLE Towns

--07. Create Table People

CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(2048),
	Height Decimal(3,2),
	[Weight] Decimal(3,2),
	Gender CHAR(1) NOT NULL,
		CHECK(Gender in ('m','f')),
	Birthdate DATETIME2 NOT NULL,
	Biography NVARCHAR(MAX)
)
--DROP TABLE People
--ALTER TABLE People
--ADD CONSTRAINT PK_People
--PRIMARY KEY(Id)

INSERT INTO People 
		([Name], Gender, Birthdate)
	VALUES
		('Pesho','m', '1998-05-05'),
		('Andrey','m', '1998-05-05'),
		('Alex','F', '1998-05-05'),
		('Petq','F', '1998-05-05'),
		('Vasko','M', '1998-05-05')
SELECT * FROM People
TRUNCATE TABLE People

-- 08 Create Table

CREATE TABLE Users
(
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(900),
	LastLoginTime DATETIME2,
	IsDeleted BIT
)
SELECT * FROM Users
INSERT INTO Users
		(Username,[Password])
	VALUES
		('Andrey', '000216'),
		('Bilbo', '000216'),
		('Aleks', '000216'),
		('Dani', '000216'),
		('BamBam', '000216')

-- 09. Change Primary Key

ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC0763FA4396

ALTER TABLE Users
ADD CONSTRAINT PK_UserTable PRIMARY KEY(Id, Username)

--10. Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordIsAtLeast5Symbols
CHECK(LEN([Password]) >=5)
SELECT * FROM Users

--Bonus
UPDATE Users
SET [Password] = 123456
WHERE LEN([Password]) <=5

--11. Set Default Value of a Field
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
Default Getdate() for [LastLoginTime]

--12 Set Unique Field
ALTER TABLE Users
Drop Constraint PK_UserTable

ALTER TABLE Users
ADD CONSTRAINT PK_OnlyID PRIMARY KEY (Id)

ALTER TABLE Users
ADD CONSTRAINT CHK_UsernameLenghtIsAtLeast3Symbols
CHECK (LEN(Username) >= 3)

--13 Moovies DataBase

CREATE DATABASE Moovies
GO
USE Moovies
GO

CREATE TABLE Directors
(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(255) NOT NULL,
	Notes NVARCHAR(MAX) 
)

INSERT INTO Directors(DirectorName)
	VALUES('Andrey'),
		  ('Alex'),
		  ('Dani'),
		  ('BamBam'),
		  ('BumBum')

Create Table Genres
(
	Id Int Primary Key Identity,
	GenreName NVARCHAR(100) not null,
	Notes Nvarchar(max)
)

Insert into Genres(GenreName)
Values('Documental'),
	  ('Action'),
	  ('Horror'),
	  ('Comedy'),
	  ('Drama')
	  
Create Table Categories
(
	Id INT primary key identity,
	CategoryName nvarchar(100) not null,
	Notes nvarchar(max)
)
insert into Categories(CategoryName)
values('first'),
	  ('second'),
	  ('third'),
	  ('fourth'),
	  ('Fifth')
	  

Create table Movies
(
	Id int primary key identity,
	Title nvarchar(100) not null,
	DirectorId int foreign key references Directors(Id) not null,
	CopyrightYear int not null,
	Lenght int not null,
	GenreId Int foreign key references Genres(Id) not null,
	CategoryId int foreign key references Categories(Id) not null,
	Rating float not null,
	Notes nvarchar(max)
)


Insert into Movies
values('BigBang', 2, 2024, 183, 1, 5, 3.2, null),
      ('BigBang', 2, 2024, 183, 1, 5, 3.2, null),
	  ('BigBang', 2, 2024, 183, 1, 5, 3.2, null),
	  ('BigBang', 2, 2024, 183, 1, 5, 3.2, null),
	  ('BigBang', 2, 2024, 183, 1, 5, 3.2, null)

select * from Movies

--14 . Car Rental Database

CREATE DATABASE CarRental
GO

USE CarRental
GO

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(50) NOT NULL,
	DailyRate MONEY NOT NULL,
	WeeklyRate MONEY NOT NULL,
	MonthlyRate MONEY NOT NULL,
	WeekendRate MONEY NOT NULL
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber VARCHAR(20) NOT NULL,
	Manufacturer VARCHAR(50) NOT NULL,
	Model VARCHAR(50) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Doors INT NOT NULL,
	Picture VARBINARY(MAX),
	Condition VARCHAR(10),
	Available BIT DEFAULT 1 NOT NULL
)


CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Title VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber VARCHAR(50) NOT NULL,
	FullName VARCHAR(200) NOT NULL,
	Adress VARCHAR(200) NOT NULL,
	City VARCHAR(200) NOT NULL,
	ZIPCode VARCHAR(10) NOT NULL,
	Notes VARCHAR(MAX)
)


CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel VARCHAR(20) NOT NULL,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT  NOT NULL,
	StartDate DATETIME2 NOT NULL,
	EndDate DATETIME2 NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied VARCHAR(20) NOT NULL,
	TaxRate MONEY NOT NULL,
	OrderStatus VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
	 VALUES
		   ('Jeep', 20,100,300,50),
		   ('Van', 20,100,300,50),
		   ('Bus', 20,100,300,50)



INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available)
	 VALUES
	       ('PB3727TT', 'Mercedes', 'ML', 2024, 1, 5, 'New', 1),
		   ('PB3727TT', 'Audi', 'ML', 2024, 1, 5, 'New', 1),
		   ('PB3727TT', 'BMV', 'ML', 2024, 1, 5, 'New', 1)

INSERT INTO Employees (FirstName, LastName, Title)
		VALUES
			  ('Ivan', 'Ivanov', 'Salesman'),
			  ('Ivan', 'Ivanov', 'Salesman'),
			  ('Ivan', 'Ivanov', 'Salesman')

INSERT INTO Customers (DriverLicenceNumber, FullName, Adress, City, ZIPCode)
		VALUES
			  ('asd34223g23', 'Andrey Matsev', 'Budeshte 2a', 'Plovdiv', '4000'),
			  ('asd34223g23', 'Test1', 'Budeshte 2a', 'Plovdiv', '4000'),
			  ('asd34223g23', 'Test2', 'Budeshte 2a', 'Plovdiv', '4000')



INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus)
		VALUES
			  (1, 1, 3, 'full', 0, 100, 105, '2024/05/01', '2024/05/17', 16, 'Monthly', 500, 'Completed'),
			  (1, 1, 3, 'full', 0, 100, 105, '2024/05/01', '2024/05/17', 16, 'Monthly', 500, 'Completed'),
			  (1, 1, 3, 'full', 0, 100, 105, '2024/05/01', '2024/05/17', 16, 'Monthly', 500, 'Completed')


select * from RentalOrders
Use Minions
drop database CarRental


--15. Hotel Database

CREATE DATABASE Hotel
GO
Use Hotel
GO

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Title VARCHAR(100) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title, Notes)
	 VALUES
		   ('Vasil', 'Dimitrov', 'Receptionist', 'Lazy'),
		   ('Vasil', 'Dimitrov', 'Receptionist', 'Lazy'),
		   ('Vasil', 'Dimitrov', 'Receptionist', 'Lazy')

CREATE TABLE Customers
(
	Accountnumber INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(50) NOT NULL,
	EmergencyName VARCHAR(100) NOT NULL,
	EmergencyNumber VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Customers(FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber)
	 VALUES
           ('Andrey', 'Matsev', '+359-897-967-043', 'Aleks', '+359-897-456-897'),
		   ('Andrey', 'Matsev', '+359-897-967-043', 'Aleks', '+359-897-456-897'),
		   ('Andrey', 'Matsev', '+359-897-967-043', 'Aleks', '+359-897-456-897')


CREATE TABLE RoomStatus
(
	RoomStatus INT PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX) NOT NULL
)

INSERT INTO RoomStatus(RoomStatus, Notes)
	 VALUES
		   (1, 'Available'),
		   (2, 'Occupied'),
		   (3, 'Leaving Today')

CREATE TABLE RoomTypes
(
	RoomTypes INT PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX) NOT NULL
)

INSERT INTO RoomTypes (RoomTypes, Notes)
	 VALUES
	       (1, 'Single'),
		   (2, 'Double'),
		   (3, 'Appartmenet')

CREATE TABLE BedTypes
(
	BedTypes INT PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX) NOT NULL,
)

INSERT INTO BedTypes (BedTypes, Notes)
	 VALUES
		   (1, '1PBed'),
		   (2, '2PBed'),
		   (3, 'QuinBed')
		   
CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY NOT NULL,
	RoomType INT FOREIGN KEY REFERENCES RoomTypes(RoomTypes) NOT NULL,
	BedType INT FOREIGN KEY REFERENCES BedTypes(BedTypes) NOT NULL,
	Rate MONEY NOT NULL,
	RoomStatus INT FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus)
	 VALUES
	       (101, 1, 1, 50, 1),
		   (203, 2, 2, 90, 2),
		   (408, 3, 3, 150, 2)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATETIME2 NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATETIME2 NOT NULL,
	LastDateOccupied DATETIME2 NOT NULL,
	TotalDays INT NOT NULL,
	AmmountCharged MONEY NOT NULL,
	TaxRate MONEY NOT NULL,
	TaxAmount INT NOT NULL,
	PaymentTotal MONEY NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmmountCharged, TaxRate, TaxAmount, PaymentTotal)
	 VALUES
		   (1, '2024/05/17', 1, '2024/05/12', '2024/05/12', 5, 750, 150, 5, 800),
		   (1, '2024/05/17', 1, '2024/05/12', '2024/05/12', 5, 750, 150, 5, 800),
		   (1, '2024/05/17', 1, '2024/05/12', '2024/05/12', 5, 750, 150, 5, 800)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied DATETIME2 NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied MONEY NOT NULL,
	PhoneCharge MONEY NOT NULL,
	Note VARCHAR(MAX)
)

INSERT INTO Occupancies ( EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge)
	 VALUES 
		   (1, '2024/05/12', 1, 408, 150, 50),
		   (1, '2024/05/12', 1, 408, 150, 50),
		   (1, '2024/05/12', 1, 408, 150, 50)

TRUNCATE TABLE Occupancies
select * from Occupancies

UPDATE Payments
SET TaxRate = TaxRate * 0.97
SELECT TaxRate FROM Payments

Use Minions
GO
DROP DATABASE Hotel

--16. Create SoftUni Database

CREATE DATABASE SoftUni
USE SOFTUNI
GO

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(100) NOT NULL
)

CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	AddressText NVARCHAR(200) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
)

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(100) NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(100) NOT NULL,
	MiddleName NVARCHAR(100)NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	JobTitle NVARCHAR(100) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATETIME2 NOT NULL,
	Salary Money NOT NULL,
	AddressID INT FOREIGN KEY REFERENCES Addresses(Id)
)
--DROP TABLE EMPLOYEES
select * from Employees 
--ALTER TABLE Towns
--Drop Constraint PK__Towns__3214EC07BF35ECED

--DROP TABLE Towns
--DROP TABLE Addresses

--17 backup

--18. Basic Insert

select * from Towns

INSERT INTO Towns
	VALUES('Sofia'),
		  ('Plovdiv'),
		  ('Varna'),
		  ('Burgas')

INSERT INTO Departments
	VALUES('Engineering'),
		  ('Sales'),
		  ('Marketing'),
		  ('Software Development'),
		  ('Quality Assurance')
select * from Departments

INSERT INTO Employees(FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary)
	VALUES('Ivan', 'Ivanov', 'Ivanov','.NET Developer', 4, '2013-02-01', 3500.00),
	      ('Petar', 'Petrov', 'Petrov','Senior Engineer', 1, '2004-03-02', 4000.00),
		  ('Maria', 'Petrova', 'Ivanova','Intern', 5, '2016-08-28', 525.25),
		  ('Georgi', 'Teziev', 'Ivanov','CEO', 2, '2007-12-09', 3000.00),
		  ('Peter', 'Pan', 'Pan','Intern', 3, '2016-08-28', 599.88)

--19 Basic Select All
          select * from Towns 
		  select * from Departments
		  select * from Employees

--20 Basic Select All Fields and Order them
		  select * from Towns
		  ORDER BY [Name] 
		  select * from Departments
		  ORDER BY [Name]
		  select * from Employees
		  ORDER BY Salary DESC

--21 Basic Select Some Fields
select [Name] from Towns
ORDER BY [Name]
select [Name] from Departments
ORDER BY [Name]
select FirstName, LastName, JobTitle, Salary from Employees
ORDER BY Salary DESC

--22 Increase Employes Salary
UPDATE Employees
SET Salary = Salary * 1.1
select Salary from Employees

--23 Decrease Tax Rates

