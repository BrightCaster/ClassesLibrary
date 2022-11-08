CREATE DATABASE Testing;

CREATE TABLE Products (id INT PRIMARY KEY, name VARCHAR(255) NOT NULL, counts INT);
CREATE TABLE Categories (id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE ProdCat (product INT FOREIGN KEY (product) REFERENCES Products (id), category INT FOREIGN KEY (category) REFERENCES Categories (id));

INSERT INTO Products VALUES (1,'shirt', 15),(2,'shorts',10),(3,'chips',40),(4,'water',150);
INSERT INTO Categories VALUES (1,'clothes'),(2,'foods');
INSERT INTO ProdCat VALUES (1,1),(2,1),(1,2),(3,2),(4,2);

SELECT Products.name, Categories.name
FROM ProdCat AS PC
LEFT JOIN Products ON Products.id=PC.product
LEFT JOIN Categories ON Categories.id=PC.category