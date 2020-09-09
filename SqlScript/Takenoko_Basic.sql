--SQL
--命名規約(Namming rule)
Create Table MUser
(UserID Nvarchar(32) Not NULL
,DisplayName Nvarchar(100) Not Null
,BodyHeight Int Not Null
)
GO

select UserID, DisplayName, BodyHeight from MUser

select UserID, DisplayName, BodyHeight from MUser
where BodyHeight > 170

insert into MUser values('123456', '田中英雄', 174)
insert into MUser values('123462', '高橋誠', 170)

select UserID, DisplayName, BodyHeight from MUser
where UserID = '123462'

update MUser
set DisplayName = '松田隆'
, BodyHeight = 172
where UserID = '123462'

delete MUser
where UserID = '123462'

select UserID, DisplayName, BodyHeight from MUser

--誕生日列の追加
Alter Table MUser Add Birthday DATE 
Go
update MUser set Birthday = '1999/1/1'
Go
Alter Table MUser Alter Column Birthday DATE Not Null
Go

insert into MUser values('123462', '松田隆', 170, '2000-3-1')
insert into MUser values('123465', '伊藤誠', 180, '2001-10-1')


--誕生日列の削除
Alter Table MUser Drop Column Birthday
Go

--Drop Table MUser
Go


select * from MUser

insert into MUser values('123470', '秋山尚子', 152, '2002-6-7')
insert into MUser values('123471', '佐藤香織', 156, '2003-7-16')
insert into MUser values('123472', '松坂直人', 172, '2004-2-19')
insert into MUser values('123473', '藤本麻美', 149, '2005-11-22')
insert into MUser values('123474', '増田修', 186, '1998-7-29')

select * from MUser
where BodyHeight < 150 or 180 < BodyHeight 

select * from MUser
where 150 < BodyHeight and BodyHeight < 180 

select * from MUser
where BodyHeight BETWEEN 156 and 174


select * from MUser
where (BodyHeight < 150 or 180 < BodyHeight) 
and Birthday >= '2000-1-1'


insert into MUser values('123470', '石原さくら', 164, '2002-5-23')
insert into MUser values('123471', '堀北めぐみ', 167, '2003-12-16')

select * from MUser
order by BodyHeight desc

insert into MUser values('123474', '松平浩一郎', 170, '2002-5-3')
insert into MUser values('123475', '中村博之', 172, '2003-10-11')

select * from MUser
order by BodyHeight desc, Birthday asc


select DisplayName, BodyHeight from MUser
where BodyHeight >= 170
order by BodyHeight asc

select top 7 * from MUser
order by BodyHeight desc, Birthday asc


insert into MUser values('123475', '中村博之', 192, '1996-6-11')

select * from MUser
order by UserID

update MUser
set BodyHeight = 173
where UserID = '123475'


Alter Table MUser Add Contraint MUser_PrimaryKey Primary Key Clustered (UserID)
Go

update MUser set UserID = '123463' where DisplayName = '高橋誠'
update MUser set UserID = '123480' where DisplayName = '秋山尚子'
update MUser set UserID = '123481' where DisplayName = '堀北めぐみ'
update MUser set UserID = '123484' where DisplayName = '増田修'
update MUser set UserID = '123475' where DisplayName = '中村博之' and BodyHeight = 172

select * from MUser
order by UserID


insert into MUser values('123477', '川田勝利', 176, '2003-10-26')

select * from MUser
order by UserID

update MUser
set BodyHeight = 193
where UserID = '123485'


Create Table MUser1
(UserID Nvarchar(32) Not NULL
,DisplayName Nvarchar(100) Not Null
,BodyHeight Int Not Null
,Birthday Date Not Null

,Constraint MUser1_PrimaryKey Primary Key Clustered (UserID)
)
GO

/*
Drop Table MUser1
Go
*/


--10月生まれ　Month
select DisplayName as 名前, Birthday as 誕生日
, YEAR(Birthday) as BirthdayYear 
, MONTH(Birthday) as BirthdayMonth
from MUser
where MONTH(Birthday) = 10

--10月生まれ　Datepart
select DisplayName as 名前, Birthday as 誕生日
, DATEPART(MM, Birthday) as 月
from MUser
where DATEPART(MM, Birthday) = 10


--生まれてからの日数 Datediff
select DisplayName, Birthday
, CONVERT(Date, GETDATE()) as 今日
, DATEDIFF(DAY, Birthday, CONVERT(Date, GETDATE())) as 生まれてからの日数
from MUser

--２０歳以下の人 DateAdd
select DisplayName, Birthday
, DATEADD(YEAR, -20, CONVERT(Date, GETDATE())) as '20年前の日'
from MUser
where DATEADD(YEAR, -20, CONVERT(Date, GETDATE())) < Birthday






