create database stock_system


drop table USERS

create table Login
(
 username nvarchar(20),
 password nvarchar(20)
)

insert into Login(username,password)values
('Admin','12345')


select * from Login

/*login password and the username are gereated*/
/*now we going to gerenate the stored procedure for login*/
Create procedure sp_login
@username nvarchar(20),
@password nvarchar(20)
As
Begin
 select * from Login where username=@username
 and password =@password
End

/*after the admin login */
/*then we can create the tables for each sections*/
/*
categories
products
stock
supplier
customer
bill
transactions*/


/*create the table for the rejister the customers*/
CREATE TABLE CUSTOMER(
Customer_ID INT PRIMARY KEY,
Customer_name Varchar(40) NOT NULL,
Address Varchar(200) NOT NULL,
Email Varchar(200) NOT NULL UNIQUE,
Mobile_phone Varchar(50) NOT NULL UNIQUE,
)

select * from CUSTOMER;


/*create the table for the suppliers*/
CREATE TABLE SUPPLIERS(
Supplier_ID INT PRIMARY KEY,
Supplier_name Varchar(40) NOT NULL,
Address Varchar(200) NOT NULL,
Company Varchar(200) NOT NULL,
Email Varchar(200) NOT NULL,
Mobile_phone Varchar(50) NOT NULL,
)

/*create the table for the CATEGORIES*/
CREATE TABLE CATEGORIES(
Category_ID INT PRIMARY KEY IDENTITY(1,1),
Category_name Varchar(100) NOT NULL,
Category_description Varchar(max) NULL,
)

select * from CATEGORIES;
select * from SUPPLIERS;
select * from PRODUCTS;
select * from PRODUCTS
select * from TRANSACTION_DATA;
select * from STOCK_DATA;

/*create the table for the PRODUCTS*/
CREATE TABLE PRODUCTS(
Product_ID INT PRIMARY KEY,
Supplier_ID INT NOT NULL,
Category_ID INT NOT NULL,
Product_name Varchar(200) NOT NULL,
Product_description Varchar(200) NOT NULL,
Product_price DECIMAL(20,2) NOT NULL,
Unit_Quantity Varchar(40) NOT NULL,
Stock_units INT NOT NULL,
CONSTRAINT FOK_SUPPLIER FOREIGN KEY(Supplier_ID) REFERENCES SUPPLIERS(Supplier_ID),
CONSTRAINT FOK_CATEGORIES FOREIGN KEY(Category_ID) REFERENCES CATEGORIES(Category_ID),
)

EXEC sp_rename 'PRODCUTS', 'PRODUCTS';

/*create the table for the STOCK DETAILS*/
CREATE TABLE STOCK_DATA(
Stock_ID INT PRIMARY KEY ,
Prodcut_ID INT NOT NULL,
Quantity INT NOT NULL,
CONSTRAINT FOK_PRODUCTS FOREIGN KEY(Prodcut_ID) REFERENCES PRODUCTS(Product_ID),
CONSTRAINT CHECK_Quantity CHECK (Quantity>0),
)

/*create the table for the TRANSACTION INFORMATIONS*/
CREATE TABLE TRANSACTION_DATA(
Transaction_ID INT PRIMARY KEY ,
Customer_ID INT NOT NULL,
Prodcut_ID INT NOT NULL,
Quantity INT NOT NULL,
Transaction_Date DATETIME NOT NULL,
Price DECIMAL(20,2) NOT NULL,
CONSTRAINT FOK01_PRODUCTS FOREIGN KEY(Prodcut_ID) REFERENCES PRODUCTS(Product_ID),
CONSTRAINT FOK01_CUSTOMER FOREIGN KEY(Customer_ID) REFERENCES CUSTOMER(Customer_ID),
CONSTRAINT CHECK01_Quantity CHECK (Quantity>0),
CONSTRAINT CHECK01_Price CHECK (Price>0),
)

/*create the table for the bill data*/
CREATE TABLE BILL_DATA(
Bill_ID INT PRIMARY KEY ,
Customer_ID INT NOT NULL,
Transaction_Date DATETIME NOT NULL,
Total_value DECIMAL(20,2) NOT NULL,
CONSTRAINT FOK_CUSTOMER FOREIGN KEY(Customer_ID) REFERENCES CUSTOMER(Customer_ID),
CONSTRAINT CHECK_Total_value CHECK (Total_value>0),
)





/*procedures creation*/

-- Create stored procedure to insert data into CUSTOMER table
CREATE PROCEDURE InsertCustomer
    @Customer_ID INT,
    @Customer_name VARCHAR(40),
    @Address VARCHAR(200),
    @Email VARCHAR(200),
    @Mobile_phone VARCHAR(50)
AS
BEGIN
    INSERT INTO CUSTOMER (Customer_ID, Customer_name, Address, Email, Mobile_phone)
    VALUES (@Customer_ID, @Customer_name, @Address, @Email, @Mobile_phone)
END

-- Create stored procedure to insert data into SUPPLIERS table
CREATE PROCEDURE Insertsupplierss
    @Supplier_ID INT,
    @Supplier_name VARCHAR(40),
    @Address VARCHAR(200),
    @Company VARCHAR(200),
    @Email VARCHAR(200),
    @Mobile_phone VARCHAR(50)
AS
BEGIN
    INSERT INTO SUPPLIERS (Supplier_ID, Supplier_name, Address, Company, Email, Mobile_phone)
    VALUES (@Supplier_ID, @Supplier_name, @Address, @Company, @Email, @Mobile_phone)
END


-- Create stored procedure to insert data into CATEGORIES table
CREATE PROCEDURE InsertCategory
    @Category_name VARCHAR(100),
    @Category_description VARCHAR(MAX)
AS
BEGIN
    INSERT INTO CATEGORIES (Category_name, Category_description)
    VALUES (@Category_name, @Category_description)
END


-- Create stored procedure to insert data into products data table

CREATE PROCEDURE InsertProductss
    @Product_ID INT,
    @Supplier_ID INT,
    @Category_ID INT,
    @Product_name VARCHAR(200),
    @Product_description VARCHAR(200),
    @Product_price DECIMAL(20, 2),
    @Unit_Quantity VARCHAR(40),
    @Stock_units INT
AS
BEGIN
    INSERT INTO PRODUCTS (Product_ID, Supplier_ID, Category_ID, Product_name, Product_description, Product_price, Unit_Quantity, Stock_units)
    VALUES (@Product_ID, @Supplier_ID, @Category_ID, @Product_name, @Product_description, @Product_price, @Unit_Quantity, @Stock_units)
END


-- Create stored procedure to insert data into STOCK_DATA table
CREATE PROCEDURE InsertStockData
    @Stock_ID INT,
    @Product_ID INT,
    @Quantity INT
AS
BEGIN
    INSERT INTO STOCK_DATA (Stock_ID, Prodcut_ID, Quantity)
    VALUES (@Stock_ID, @Product_ID, @Quantity)
END

-- Create stored procedure to insert data into TRANSACTION_DATA table
CREATE PROCEDURE InsertTransactionsData
 @Transaction_ID INT,
    @Customer_ID INT,
    @Product_ID INT,
    @Quantity INT,
    @Transaction_Date DATETIME,
    @Price DECIMAL(20, 2)
AS
BEGIN
    INSERT INTO TRANSACTION_DATA (Transaction_ID,Customer_ID, Prodcut_ID, Quantity, Transaction_Date, Price)
    VALUES (@Transaction_ID,@Customer_ID, @Product_ID, @Quantity, @Transaction_Date, @Price)
END

-- Create stored procedure to insert data into BILL_DATA table
CREATE PROCEDURE InsertBillDatas
    @Bill_ID INT,
    @Customer_ID INT,
    @Transaction_Date DATETIME,
    @Total_value DECIMAL(20, 2)
AS
BEGIN
    INSERT INTO BILL_DATA (Bill_ID, Customer_ID, Transaction_Date, Total_value)
    VALUES (@Bill_ID, @Customer_ID, @Transaction_Date, @Total_value)
END
