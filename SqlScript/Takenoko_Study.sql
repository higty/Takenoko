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




