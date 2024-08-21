--Select
--ANSII
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where categoryID=1 order by UnitPrice desc --ascending artan --descending azalan

select count(*) Adet from Products where CategoryID=2

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*) <10

select  Products.productID, Products.ProductName,Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 
--DTO Data Transformation object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID

select * from Customers c left join orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
