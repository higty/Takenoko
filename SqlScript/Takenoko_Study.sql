Create Table DPayment
(ItemName Nvarchar(100) Not NULL
,Date DATE Not NULL
,Price Int Not NULL
,CategoryName Nvarchar(100) Not NULL 
)
GO

SELECT * from DPayment

insert into DPayment values ('Dress','2020-09-01',10000,'服')
insert into DPayment values ('Tofu','2020-09-02',100,'食費')

select * from DPayment

insert into DPayment values ('Pasta','2020-09-09',1300,'食費')
insert into DPayment values ('Camera','2020-08-12',100000,'電化製品')
insert into DPayment values ('水族館入場料','2020-08-28',2500,'趣味')
insert into DPayment values ('キーホルダー','2020-08-28',200,'お土産')

UPDATE DPayment 
set ItemName ='豆腐'
where ItemName ='Tofu'

UPDATE DPayment 
set ItemName ='ドレス'
where ItemName ='Dress'

UPDATE DPayment 
set ItemName ='パスタ'
where ItemName ='Pasta'

UPDATE DPayment 
set ItemName ='カメラ'
where ItemName ='Camera'

select * from DPayment
order by Date ASC

select * from DPayment
order by Date DESC

select * from DPayment
order by Price desc

insert into DPayment values  ('キュウリ','2020-09-07',100,'食費')
insert into DPayment values  ('ニンジン','2020-09-02',100,'食費')

select * from DPayment
order by Price desc, Date asc 

UPDATE DPayment
set Date = '2020-09-03'
where ItemName　= 'ニンジン'

select top 5  * from DPayment
where Date >='2020-09-02'
order by Price desc


alter table DPayment add ID Int
GO
select * from DPayment

UPDATE DPayment set ID = '1' where ItemName ='ドレス'
UPDATE DPayment set ID = '2' where ItemName ='豆腐'
UPDATE DPayment set ID = '3' where ItemName ='パスタ'
UPDATE DPayment set ID = '4' where ItemName ='カメラ'
UPDATE DPayment set ID = '5' where ItemName ='水族館入場料'
UPDATE DPayment set ID = '6' where ItemName ='キーホルダー'
UPDATE DPayment set ID = '7' where ItemName ='キュウリ'
UPDATE DPayment set ID = '8' where ItemName ='ニンジン'

alter table DPayment alter COLUMN ID Int Not NULL
GO

alter table DPayment add CONSTRAINT DPayment_PrimaryKey primary key CLUSTERED (ID)
GO

insert into DPayment values ('みかん','2020-09-04',50,'食費',9)

update DPayment set Price = 90 where ID = 8

insert into DPayment values ('キュウリ','2020-08-31',100,'食費',10)
update DPayment set Price =120 where ID=10

update DPayment set Price =200 where ID=6

Create Table DAppLock
(AppCD UniqueIdentifier Not Null 
,LockType Nvarchar(100) Not Null 

,Constraint DAppLock_PrimaryKey Primary Key Clustered(AppCD,LockType)
,Constraint DAppLock_Fk_AppCD Foreign Key(AppCD) References MApp(AppCD)On Update No Action On Delete Cascade
)
Go

Alter Table DAppLock Add Constraint DAppLock_Check_LockType Check(LockType in('UserAdd'))
Go