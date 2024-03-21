create table Products 
(
	Id int not null identity(1,1) primary key,
	Name nvarchar(max) not null check(Name <> N''), 
)

create table Categories
(
	Id int not null identity(1,1) primary key,
	Name nvarchar(max) not null check(Name <> N''), 
)

create table ProductsCategories
(
	Id int not null identity(1,1) primary key,
	ProductId int not null foreign key(ProductId) references Products(Id), 
	CategoryId int null foreign key(CategoryId) references Categories(Id)
)

select p.Name as 'Название продукта', c.Name as 'Категория' from Products p 
left join ProductsCategories as pc on p.Id = pc.ProductId
left join Categories c on pc.CategoryId = c.Id



