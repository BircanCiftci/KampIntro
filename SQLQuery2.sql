--Select
--ANSII
Select ContactName Adi, CompanyName , City from Customers

select * from Customers where City = 'Berlin'

--case insensitive büyük küçük harf duyarsız
select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products order by UnitPrice desc --ascending --descending

select * from Products where categoryId = 3 order by UnitPrice desc

select count(*) adet from Products where CategoryID = 2

select categoryID, COUNT(*) from products group by CategoryID

select categoryID, COUNT(*) from products group by CategoryID having count(*)<10

select categoryID, COUNT(*) from products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Customers c right join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null


select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID