﻿CREATE DATABASE POS_DB;

CREATE table CATEGORIES
( ID_CAT int PRIMARY KEY IDENTITY(1,1) NOT NULL,DESCRIPTION_CAT nvarchar(25) );
--CATEGORIES
INSERT INTO CATEGORIES 
VALUES(N'الهواتف');
INSERT INTO CATEGORIES 
VALUES(N'الأفلام');
INSERT INTO CATEGORIES 
VALUES(N'الكتب');
INSERT INTO CATEGORIES 
VALUES(N'الأثاث');
INSERT INTO CATEGORIES 
VALUES(N'الأجهزة الإلكترونية');
SELECT * 
FROM CATEGORIES
CREATE table PRODUCTS
( ID_PRODUCT varchar(30) PRIMARY KEY NOT NULL,LABEL_PRODUCT varchar(30),QTE_IN_SROCK int,PRICE varchar(50),IMAGE_PRODUCT image );
select * from PRODUCTS

CREATE table CUSTOMERS
( ID_CUSTOMER int PRIMARY KEY IDENTITY(1,1) NOT NULL,FIRST_NAME nvarchar(25),LAST_NAME nvarchar(25),TEL nchar(15),EMAIL varchar(25),IMAGE_CUSTOMER image );

SELECT * 
FROM CUSTOMERS


CREATE table ORDERS
( ID_ORDER int PRIMARY KEY NOT NULL,DATE_ORDER datetime );
ALTER table ORDERS
ADD DESCRIPTION_ORDER Nvarchar(250);
ALTER table ORDERS
ADD SALESMAN varchar(75);
select * from ORDERS

ALTER table ORDERS
ADD CUSTOMER_ID INT;
ALTER TABLE ORDERS
DROP COLUMN DESCRIPTION_ORDER;

ALTER TABLE ORDERS
ALTER COLUMN SALESMAN Nvarchar(75);


CREATE table ORDERS_DETAILS
( ID_PRODUCT varchar(30),ID_ORDER int,QTE int );
ALTER table ORDERS_DETAILS
ADD PRICE varchar(50);
ALTER table ORDERS_DETAILS
ADD DISCOUNT float;
ALTER table ORDERS_DETAILS
ADD AMOUNT varchar(50);
ALTER table ORDERS_DETAILS
ADD TOTAL_AMOUNT varchar(50);

select * from ORDERS_DETAILS

--FK PRODUCTS
ALTER table PRODUCTS
ADD ID_CAT int;
ALTER table PRODUCTS
ADD FOREIGN KEY (ID_CAT) REFERENCES CATEGORIES (ID_CAT) ON DELETE CASCADE ON UPDATE CASCADE;

-- FK ORDERS
ALTER table ORDERS
ADD CUSTOMER_ID int;
ALTER table ORDERS
ADD FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS (ID_CUSTOMER) ON DELETE CASCADE ON UPDATE CASCADE;

-- FK ORDERS_DETAILS
ALTER table ORDERS_DETAILS
ADD FOREIGN KEY (ID_PRODUCT) REFERENCES PRODUCTS (ID_PRODUCT) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER table ORDERS_DETAILS
ADD FOREIGN KEY (ID_ORDER) REFERENCES ORDERS (ID_ORDER) ON DELETE CASCADE ON UPDATE CASCADE;


CREATE table USERS
( ID nvarchar(50) PRIMARY KEY NOT NULL,PWD varchar(50),UserType nvarchar(50) );
ALTER table USERS
ADD FullName nvarchar(100);
INSERT INTO USERS 
VALUES('admin','ad123',N'مدير','Tawfik Yasser');
INSERT INTO USERS 
VALUES('user 1','us345',N'عادي','User Full name');
select * from users
delete users
drop table USERS
ALTER TABLE USERS
ALTER COLUMN ID Nvarchar(50);


ALTER Database POS_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
