USE Warehouse;

INSERT INTO Manufacturers(Name)
VALUES('Chumak'),
      ('NestleUkraine'),
      ('SouthernMachine-BuildingPlant'),
      ('KharkovTractorPlant'),
      ('PharmaceuticalCompanyDarnytsia'),
      ('OdessaPortPlant')

INSERT INTO Products(Name,Type, Quantity,PrimeCost, DateOfDelivery, IdManufacturer)
VALUES('Ketchup',     'Food', 15,12.3,'2024-12-03', 1),
      ('FoodForKids', 'Food', 18,10.6,'2024-11-02', 2), 
      ('Combine',     'Technol', 3,1500000,'2022-02-08', 3),
      ('Tractor',     'Technol', 8,120000,'2021-09-09', 4),
      ('Aspirin',     'Pharmaceutical' ,80,13.8,'2024-02-02', 5),
      ('Fertilizer',  'Plants',65,14.9,'2023-04-08', 6)