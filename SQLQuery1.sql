select * from Customers  --müşteriler tablosunu getirir --müşteriler tablosundaki bütün sütunları seçer

select CompanyName, City FROM Customers -- Müşteriler tablosundan şirket adı ve şehir sütunları seçilir

select Country from Customers --birden fazla tekrar eden ülkeleride geçitir
--ama distinct getirmez tekrarı olanalrı 1 defa getirir
select DISTINCT Country from Customers

select count(DISTINCT country) from Customers --count toplam ülke sayısını getirir

-- where koşuldur belirli bir koşulu sağlayan kayıtları ayıklamak için kullanılır
--yalnızca select te değil update ve delete de de kullanılır
select * from Customers where country = 'mexico'
select * from Customers where CustomersID=1

--and örnek
select * from Customers where Country='Germany' and City='Berlin'

--or örnek
select * from Customers where city = 'Berlin' or City = 'München'
select * from Customers where country = 'Germany' or country = 'Spain'

--not örnek
select * from Customers where not Country = 'germany'

--and or not birleişimi önce parantez içi çözülür
select * from Customers 
where Country = 'germany' and (City='berlin' or city='münchen')

select * from Customers
where not Country='germany' and not Country ='USA'

--ORDER BY KELİMEYE GÖRE SIRALAMA
--artan sırada sıralar azalan sırada sıralamak için desc kullanılır
select * from Customers order by Country
select * from Customers order by Country desc
--birkaç sütuna göre sıralama
select* from Customers order by Country, CompanyName
select* from Customers order by Country asc , CompanyName desc

--insert into yeni veri ekleme
INSERT INTO Customers(CustomerID,CompanyName, ContactName, Address, City, PostalCode, Country)
values ('gfdgd','cardinal', 'tom b. erichsen', 'skagen 21', 'stavanger', '4006', 'norway');

--yalnızca belirtilen sütunlara ekleme
INSERT INTO Customers (CustomerName, City, Country)
VALUES ('Cardinal', 'Stavanger', 'Norway');

--null değerleri
-- is null
select CompanyName, ContactName, Address
from Customers
where Address is null  -- null değerleri aramak için her zaman bunu kullanmalıyız

--is not null
SELECT CompanyName, ContactName, Address
FROM Customers
WHERE Address IS NOT NULL;

--update güncelleme işlemi mevcut kayıtları güncellemek için kullanılır
update Customers
set ContactName = 'Alfred Schmidt', City = 'Berlin'
where Country='germany'
--birden fazla kaydı güncelleme 
update Customers
set ContactName = 'Juan'
where Country= 'Mexico' 
--update de where kullanmayı unutmayın yoksa tüm kayıtlar değişir

--delete silme işlemi
delete from Customers where CompanyName = 'Alfreds Futterkiste'
-- tüm tabloları siler
delete from Customers

--top limit rownum clause
--top yan tümcesi döndürülecek kayıtların sayısını belirtmek için kullanılır
select top 3 * from Customers
--top percent
select top 50 percent * from Customers; --ilk %50 ini göster
--madde ekleme 
select top 3 * from Customers where Country = 'Germany'

--min max işlemleri
--min seçilen sütündaki en küçük değeri getirir
select min(UnitPrice) as SmallestPrice from Products

--max seçilen sütündaki en büyük değeri getirir
select max(UnitPrice) as LargestPrice from Products

--count avg sum işlevleri
--count belirli bir ölçütle eşleşen satırların sayısını döndürür -- null değerler sayılmaz
select count(ProductId) from Products
--avg sayısal sütunun ortalama değerini döndürür -- null değerler göz ardı edilir
select avg(UnitPrice) from Products
--sum bir sayısal sütunun toplam toplamını döndürür -- nul değerler göz ardı edilir
select sum(Quantity) from [Order Details]

--like operatörü bir sütundaki belirli bir modeli aramak için bir WHERE yan tümcesinde kullanılır
-- % işareti 0 1 veya birden çok karakteri temsil eder
-- _ tek bir karakteri temsil eder
select * from customers
where companyname like 'a%' -- a ile başlayan % anın arkasında
select * from customers
where companyname like '%a' -- a ile biten % anın önünde
select * from customers
where companyname like '%or%'  -- companyname in herhangi bir yerinde or yaanları bulur 
select * from customers
where companyname like '_r%'  -- ikinci harfinde r olanları bulur
select * from customers
where companyname like 'a__%' --a ile başlayan ve en az 3 karakter uzunluğunda olan companyname e sahip tüm müşteileri bulur
select * from customers
where ContactName like 'a%o' -- a ile başlayan o ile bitenleri bulur
select * from customers
where CompanyName not like 'a%' --a ile başlamayanları bulur

-- % joker karakterini kullanma
select * from customers where city like 'ber%' -- ber ile başlayanları bulma
select * from customers where city like '%es%' 
-- _ jokerini karakterini kullanma 
select * from customers where city like '_ondon'
select * from customers where city like 'L_n_on'
-- [ ] jokerini karakterini kullanma 
select * from customers where city like '[bsp]%' -- b, s, p ile başlayan şehirleri bulma
select * from customers where city like '[a-c]%' -- a, b, c ile başlayan şehirleri bulma
-- [! ] jokerini karakterini kullanma 
select * from customers where city like '[!bsp]%' -- b, s, p ile başlamayan şehirleri bulma
select * from customers where city not like '[bsp]%'

-- in operatörü where yan tümcesine birden fazla değer belirtmemize izin verir birden çok or koşulu için kısaltmadır
select * from Customers
where Country in ('Germany', 'France', 'UK') -- almanya frensa ingilterede olanları bulur
select * from Customers
where Country not in ('Germany', 'France', 'UK') -- almanya frensa ingilterede olmayanları bulur
select * from Customers
where Country in (select Country from Suppliers) -- tedarikçilerle aynı ülkelerden olan tüm müşterileri seçer

-- between operatörü belirli bir aralıktaki değerleri seçer değerler sayısal metin veya tarih olabilir
-- between operatörü kapsayıcıdır: başlangıç ve nitiş değerleri dahildir
select * from Products
where UnitPrice between 10 and 20 -- 10 ile 20 arasındakiler 10 20 dahil
select * from Products
where UnitPrice not between 10 and 20 -- 10 20 arasında olmayanlar 10 20 dahil

select * from Products
where UnitPrice between 10 and 20 
and CategoryID not in (1,2,3) -- 10 ve 20 arasında olan 10 20 dahil product ıd si 1,2,3 olmayanları getir

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;  -- bu iki metin değeri arasında olanları sırala bunlarda dahil

SELECT * FROM Products
WHERE ProductName NOT BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;  -- bu iki metin değeri arasında olmayan bu metinlerde dahil

-- tarihler arası
SELECT * FROM Orders
WHERE OrderDate BETWEEN '1996-07-01' AND '1996-07-31';

select ProductName [Ürün Adi], sum( od.UnitPrice * od.Quantity) [Kazanılan Toplam Miktar]
from Products p 
inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on od.OrderID = o.OrderID 
group by p.ProductName 
order by ProductName, sum( od.UnitPrice * od.Quantity) desc