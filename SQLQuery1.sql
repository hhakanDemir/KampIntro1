--Select
select ContactName, CompanyName, City from Customers;

select * from Customers where City = 'London';

-- case insensitive

sElECt *from Products where categoryId=1 or categoryId=3;

select * from Products where categoryId=1 and UnitPrice >= 10;

select * from Products order by ProductName;

select CategoryId , count(*) from Products group by CategoryId;