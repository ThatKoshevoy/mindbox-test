-- INIT database
CREATE TABLE Product (
  ProductID INT AUTO_INCREMENT KEY,
  Name VARCHAR(100)
);

CREATE TABLE Category (
  CategoryID INT AUTO_INCREMENT KEY,
  Name VARCHAR(100)
);

CREATE TABLE ProductToCategory (
   ProductToCategoryID INT AUTO_INCREMENT KEY,
   CategoryID INT,
   ProductID INT,
   FOREIGN KEY (CategoryID) REFERENCES Category (CategoryID),
   FOREIGN KEY (ProductID) REFERENCES Product (ProductID)
);


INSERT INTO Product(Name) VALUES ('Apple'), ('Chicken'), ('Water'), ('Chocolate');
INSERT INTO Category(Name) VALUES ('Fruits'), ('Meat'), ('Drinks');
INSERT INTO ProductToCategory(CategoryID, ProductID) VALUES (1, 1), (2,2), (3,3), (null, 4);


-- QUERY database
SELECT p.Name as ProductName, c.Name as CategoryID FROM Product p
JOIN ProductToCategory ptg on p.ProductID = ptg.ProductID
LEFT JOIN Category c on c.CategoryID = ptg.CategoryID;