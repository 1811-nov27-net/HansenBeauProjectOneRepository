SELECT * FROM po.Address
select * From Po.Customer
SELECT * FROM po.Ingredient
SELECT * FROM po.Inventory
select * FROM po.OrderDetail
select * FROM PO.OrderHeader
select * FROM po.Product
SELECT * FROM po.ProductRecipe
SELECT * FROM PO.Store
SELECT * FROM po.Ingredient
select * FROM po.Product
SELECT * FROM po.ProductRecipe

ALTER TABLE PO.Customer
	ADD CustomerPassword NVARCHAR(32) DEFAULT('password') NOT NULL

ALTER TABLE PO.Store
	ADD StoreName NVARCHAR(100) DEFAULT('ItaDPizza Store') NOT NULL

INSERT INTO PO.Ingredient (IngredientName, IngredientPrice)
VALUES ('Pepperoni', 1.50),
('Sausage', 1.50),
('Canadian Bacon', 1.50),
('Chicken', 1.50),
('Olives', 1.00),
('Onions', 1.00),
('Green Peppers', 1.00),
('Tomtatoes', 1.00)

INSERT INTO PO.Product (ProductName, UnitPrice)
VALUES ('Pepperoni', 12),
('Pepperoni and Sausage', 14),
('Pepperoni and Olives', 13),
('Sausage', 12),
('Sausage and Olives', 13),
('Sausage and Green Peppers', 13),
('Sausage and Canadian Bacon', 14)

INSERT INTO PO.ProductRecipe(IngredientID, ProductID, IngredientQty)
VALUES (1, 1, 1),
(1, 2, 1),
(2, 2, 1),
(1, 3, 1),
(5, 3, 1),
(2, 4, 1),
(2, 5, 1),
(5, 5, 1),
(2, 6, 1),
(7, 6, 1),
(2, 7, 1),
(3, 7, 1)

INSERT INTO PO.Address(AddressLine1, AddressLine2, City, State, ZIP, CustomerID)
VALUES ('1111 Street Lane', null, 'Arlington', 'Texas', 76019, 1)

INSERT INTO PO.Store (AddressLine1, AddressLine2, City, State, ZIP)
VALUES ('2222 Pizza Street', null, 'Arlington', 'Texas', 76019)


INSERT INTO PO.OrderHeader (CustomerID, StoreID, AddressID, TotalCost, OrderDate)
VALUES --(1, 1, 1, 12, GETDATE()),
(16, 1, 1, 12, GetDate())

INSERT INTO PO.OrderDetail (OrderID, ProductID, QtyOrdered)
VALUES (18, 2, 2)


DELETE FROM PO.orderheader
WHERE orderID > 18

