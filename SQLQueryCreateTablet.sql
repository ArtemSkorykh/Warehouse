USE Warehouse;

CREATE TABLE Manufacturers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
	[Type] NVARCHAR(100) NOT NULL,
	Quantity INT NOT NULL,
	PrimeCost MONEY NOT NULL,
	DateOfDelivery DATE NOT NULL,
	IdManufacturer INT,
	FOREIGN KEY (IdManufacturer) REFERENCES Manufacturers(Id)
)


