-- Caleb Wherry
-- 6/18/07
-- SUPPLIERS query for Northwind database

SELECT SUPPLIERID AS 'Supplier ID', COMPANYNAME AS 'Supplier Name'
FROM SUPPLIERS 
WHERE SUPPLIERID IN
( SELECT SUPPLIERID
FROM PRODUCTS 
WHERE PRODUCTID IN
( SELECT PRODUCTID
FROM [ORDER DETAILS] 
WHERE ORDERID IN
( SELECT ORDERID
FROM ORDERS 
WHERE CUSTOMERID = 'FOLKO')))