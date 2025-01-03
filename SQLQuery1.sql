create database QuanLyPhongMay
go
use QuanLyPhongMay
go 


create table GroupUser
(
	GroupName nvarchar(30) primary key,
)

go

create table Users
(
	UserID int identity primary key,
	UserName varchar(60) unique,
	FullName nvarchar(60),
	GroupUser nvarchar(30) references GroupUser(GroupName),
	PhoneNumber varchar(11),
	Email varchar(100),
	Password varchar(30)
)

go 

create table GroupClient
(
	GroupName varchar(30) primary key,
	Description nvarchar(120),
	Price float
)

go

create table Client
(
	ClientID int identity primary key,
	ClientIP varchar(20) unique,
	ClientName varchar(30) unique,
	GroupClientName varchar(30) references GroupClient(GroupName),
	StatusClient varchar(50),
)
 
 go

create table Member
(
	MemberID int identity primary key,
	AccountName varchar(30) unique,
	Password varchar(30),
	GroupUser nvarchar(30) references GroupUser(GroupName),
	CurrentMoney float,
	MemberStatus varchar(10)
)

go

create table AddMoneyTransaction
(
	AddMoneyTransactionId int identity primary key,
	ClientIP varchar(20) references Client(ClientIP) default null,
	UserName varchar(60) references Users(UserName),
	MemberName varchar(30) references Member(AccountName),
	TransacDate datetime,
	AddMoney float,
	TransacStatus varchar(20)
)

go

create table Chat
(
	ChatID bigint identity primary key,
	MemberName varchar(30) references Member(AccountName),
	UserName varchar(60) references Users(UserName),
	ClientName varchar(30) references Client(ClientName),
	Message nvarchar(200),
	CreatedAt datetime,
	SendBy varchar(10)
)


go

create table Category
(
	CategoryName nvarchar(60) primary key,
)

go

create table Product
(
	ProductID int identity primary key,
	ProductName nvarchar(30),
	CategoryName nvarchar(60) references Category(CategoryName),
	Price float,
	InventoryNumber int,
	ImageUrl varchar(100),
)

go 

create table Bill
(
	BillID int primary key identity,
	UserID int references Users(UserID),
	MemberID int references Member(MemberID),
	CreatedAt datetime,
	TotalPrice float,
	Status varchar(10)
)

go 

create table Bill_Item
(
	BillID int references Bill(BillID),
	ProductID int references Product(ProductID),
	Quantity int
)

--Nhom nguoi dung
insert into GroupUser values ('Member')
insert into GroupUser values ('Staff')
insert into GroupUser values ('Manager')
--Nguoi Dung
insert into Users values ('admin',N'Nguyễn Thanh Bảo','Manager','0961563202','nguyenthanhbao9a@gmail.com','admin')
insert into Users values ('user1',N'Phạm Phú An','Staff','0123456789','phuanpham@gmail.com','user1')
insert into Users values ('user2',N'Lê Văn Đại','Staff','097851364','daile123@gmail.com','user2')
--Thanh Vien
insert into Member values ('seraphim','123','Member',50000, 'ALLOW')
insert into Member values ('abc','123','Member',0, 'ALLOW')
insert into Member values ('xyz','123','Member',60000, 'ALLOW')
insert into Member values ('account1','123','Member',10000,'ALLOW')
insert into Member values ('account2','123','Member',10000, 'ALLOW')
--Nhom may tram
insert into GroupClient values ('basic',N'Phòng máy thường',6000)
insert into GroupClient values ('VIP',N'Phòng máy lạnh',10000)
insert into GroupClient values ('SVIP',N'Phòng vip',20000)
insert into GroupClient values ('esport',N'Phòng máy dành cho giải đấu Game',100000)
--May tram
insert into Client values ('127.0.0.1','MAY1','basic','DISCONNECT')
insert into Client values ('26.218.32.251','MAYDANH','basic','DISCONNECT')
insert into Client values ('26.201.172.187','MAYDUNG','basic','DISCONNECT')
insert into Client values ('192.168.1.14','MAY0','basic','DISCONNECT')
insert into Client values ('192.168.1.6','MAY-VIP-2','VIP','DISCONNECT')
insert into Client values ('192.168.1.7','MAY-SVIP-1','SVIP','DISCONNECT')
--danh Muc
insert into Category values(N'Mì gói')
insert into Category values(N'Cơm')
insert into Category values(N'Phở')
insert into Category values(N'Bún')
insert into Category values(N'Nước Ngọt')
insert into Category values(N'Nước suối')
insert into Category values(N'Trà')
insert into Category values(N'Bia')
insert into Category values(N'Rượu')
--thức ăn
insert into Product values (N'Mì xào trứng', N'Mì gói',15000,15,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726140648/xexjfbwzd7bain4kcsp9.jpg')
insert into Product values (N'Mì xào bò', N'Mì gói',25000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726140648/xcqvhxfnb0nkp1zdadvk.jpg')
insert into Product values (N'Cơm chiên trứng', N'Cơm',20000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726140647/uxyre1wyapzfcar56hsa.jpg')
insert into Product values (N'Cơm chiên thịt heo', N'Cơm',25000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726141312/prxg4xhsr2nzhfkmqwuy.jpg')
insert into Product values (N'Sting đỏ', N'Nước Ngọt',20000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726141302/zucj5urv7w4hd2pt29kn.jpg')
insert into Product values (N'Sting vàng', N'Nước Ngọt',20000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726141302/izwfivsbe8rncrmcdglg.jpg')
insert into Product values (N'Bò húc', N'Nước Ngọt',15000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726141302/wsoozm11e7nsrd8jkzn9.jpg')
insert into Product values (N'Aquafina', N'Nước suối',10000,20,'https://res.cloudinary.com/dale7wvyi/image/upload/v1726141302/bpl5aniijvddgsrg33ug.jpg')
--nạp tiền 
insert into AddMoneyTransaction values('127.0.0.1', 'admin', 'xyz', '2024-09-15 13:40:57',30000,'SUCCESS')
insert into AddMoneyTransaction values('127.0.0.1', 'user1', 'seraphim', '2024-09-15 13:40:57',30000,'DENIED')
insert into AddMoneyTransaction values('127.0.0.1', 'Admin', 'Seraphim', '2024-09-23 15:37:22',20000,'SUCCESS')
insert into AddMoneyTransaction values('127.0.0.1', 'Admin', 'Seraphim', '2024-09-23 15:38:23',30000,'SUCCESS')
insert into AddMoneyTransaction values('127.0.0.1', 'Admin', 'Seraphim', '2024-09-23 15:44:17',10000,'SUCCESS')
--hóa đơn mua hàng
insert into Bill values(1,1,'2024-09-15 13:40:57',30000,'SUCCESS')
insert into Bill values(2,2,'2024-09-15 13:40:57',50000,'DENIED')
insert into Bill values(1,1,'2024-09-23 15:49:54',35000,'SUCCESS')
insert into Bill values(1,1,'2024-09-23 15:51:54',50000,'SUCCESS')
insert into Bill values(1,1,'2024-09-13 15:49:54',35000,'SUCCESS')