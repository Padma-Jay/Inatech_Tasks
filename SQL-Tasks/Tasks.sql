--Task1
select FirstName, LastName
from person.person
where Title IS NOT NULL

--Task2
select FirstName, LastName
from person.person
where (FirstName like '%a%') AND (LastName like '%a%')

--Task3
select cur.CurrencyCode,Name
from Sales.Currency cur, Sales.CountryRegionCurrency  reg

--Task4
select * into HR_Dept
from HumanResources.Department
select * from HR_Dept

--Task5
create table TaskTab
(
 tfname varchar(20),
 Sno int identity(1,1),
)
--Task6
select per.BusinessEntityID, AddressTypeID
from HumanResources.Department dep join
Person.BusinessEntityAddress per on
dep.DepartmentID = per.BusinessEntityID

--Task7
select distinct GroupName
from HumanResources.Department

--Task8 -> Aggregate Function
select sum(ListPrice), sum(chis.StandardCost), ProductSubcategoryID
from Production.ProductCostHistory chis 
join Production.Product pro
on chis.ProductID = pro.ProductID
group by ProductSubcategoryID

--Task9
select DATEDIFF(year, StartDate, EndDate) Role
from HumanResources.EmployeeDepartmentHistory

--Task10
 --select 
 --from 

 --select * from Production.ProductCostHistory
 --select * from Production.ProductSubcategory
--Task11
select max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

--Task12 (nc)
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--Task 13
create view name_age
as 
select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID


--Task 14 count - To calculate no of rows in tables
select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee

--Task 15 max is an aggregate function followed by "group by"
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory pay join
HumanResources.Department dep
on pay.BusinessEntityID = dep.DepartmentID
group by Name

--Task 16
select per.FirstName, per.MiddleName, per.Title, bus.AddressTypeID, bus.BusinessEntityID
from Person.Person per join 
person.BusinessEntityAddress bus
on per.BusinessEntityID = bus.BusinessEntityID

--Task 17
select ProductID, pn.LocationID, Shelf
from Production.ProductInventory pi join
Production.Location pn 
on pi.LocationID =pn.LocationID 
where ProductID >= 300 and ProductID<=350 and pn.LocationID = 50 or shelf='E'

--Task 18
select loc.LocationID, pInt.Shelf, loc.Name
from production.ProductInventory pInt join
Production.Location loc 
on pInt.LocationID= loc.LocationID

--Task 19
select addr.AddressID, addr.AddressLine1, addr.AddressLine2, stat.StateProvinceID, stat.StateProvinceCode, stat.CountryRegionCode
from Person.StateProvince stat join
Person.Address addr 
on stat.StateProvinceID = addr.StateProvinceID

--Task 20
select CurrencyCode, sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader soh join
Sales.SalesTerritory st on
soh.TerritoryID = st.TerritoryID join
sales.CountryRegionCurrency cr
on cr.CountryRegionCode = st.CountryRegionCode
group by CurrencyCode


