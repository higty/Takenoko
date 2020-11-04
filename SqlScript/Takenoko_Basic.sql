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


select * from MUser


Alter Table MUser Add GroupName Nvarchar(64) 
GO
update MUser set GroupName = ''
GO
Alter Table MUser Alter Column GroupName Nvarchar(64) Not NULL
GO


UPDATE MUser set GroupName = 'A'
UPDATE MUser set GroupName = 'B' where BodyHeight > 167
UPDATE MUser set GroupName = 'C' where Birthday > '2003/3/3'
UPDATE MUser set GroupName = 'D' where UserID = '123474'
UPDATE MUser set GroupName = 'D' where UserID = '123475'


select GroupName from MUser
order by GroupName

select GroupName,COUNT(*) as RecordCount from MUser
group by GroupName
order by COUNT(*) desc



select GroupName,MAX(BodyHeight) as MaxHeight from MUser
group by GroupName

select GroupName,MIN(BodyHeight) as MinHeight from MUser
group by GroupName

select * from MUser
order by GroupName, BodyHeight desc

select GroupName
,MAX(BodyHeight) as MaxHeight
,MIN(BodyHeight) as MinHeight 
,SUM(BodyHeight) as SumHeight
,COUNT(*) as RecordCount
,AVG(BodyHeight) as AverageHeight
from MUser
group by GroupName


select DATEPART(YEAR, Birthday) as BirthYear
,MAX(BodyHeight) as MaxHeight 
from MUser
group by DATEPART(YEAR, Birthday)

declare @Offset Int = 2

select * from MUser
order by BodyHeight ASC
offset @Offset ROW fetch NEXT 25 rows only

select * from MUser
order by BodyHeight ASC

--トップ句
select top 4 * from MUser
order by BodyHeight ASC


Create Table MFoodCategory
(CategoryID Nvarchar(32) Not Null
,CategoryName Nvarchar(64) Not Null

,Constraint MFoodCategory_PrimaryKey PRIMARY KEY CLUSTERED(CategoryID)
)
GO

insert into MFoodCategory values('0','和食')
insert into MFoodCategory values('1','イタリアン')
insert into MFoodCategory values('2','中華料理')
insert into MFoodCategory values('3','韓国料理')
insert into MFoodCategory values('4','フレンチ')
insert into MFoodCategory values('5','タイ料理')
insert into MFoodCategory values('6','鍋料理')
insert into MFoodCategory values('7','ラーメン')

select * from MFoodCategory

Create Table MFood 
(FoodCD UNIQUEIDENTIFIER Not Null
,FoodName Nvarchar(128) Not Null
,CategoryID Nvarchar(32) Not Null

,Constraint MFood_PrimaryKey PRIMARY KEY CLUSTERED(FoodCD)
,Constraint MFood_FK_CategoryID FOREIGN KEY(CategoryID) REFERENCES MFoodCategory(CategoryID)
)
Go

insert into MFood values(NEWID(), 'カルボナーラ', '1')
insert into MFood values(NEWID(), '彩野菜のトマトソースパスタ', '1')
insert into MFood values(NEWID(), '唐揚げ定食', '0')
insert into MFood values(NEWID(), 'もつ鍋', '6')
insert into MFood values(NEWID(), 'トムヤンクン', '5')
insert into MFood values(NEWID(), 'サムギョプサル', '3')
insert into MFood values(NEWID(), 'エビチリチャーハン', '2')
insert into MFood values(NEWID(), 'フォアグラの何とかソテー', '4')
insert into MFood values(NEWID(), '塩ラーメン', '7')
insert into MFood values(NEWID(), 'ラーメン次郎', '7')
insert into MFood values(NEWID(), '一風堂', '7')

select FoodName,MFood.CategoryID,CategoryName from MFood
inner join MFoodCategory on MFood.CategoryID = MFoodCategory.CategoryID

select * from MFoodCategory
select * from MFood

select CategoryName,FoodName from MFoodCategory
inner join MFood on MFoodCategory.CategoryID = MFood.CategoryID
order by MFoodCategory.CategoryID
--where MFoodCategory.CategoryID = '7'

insert into MFoodCategory values('8','丼')

select * from MFoodCategory


select CategoryName,FoodName from MFoodCategory
inner join MFood on MFoodCategory.CategoryID = MFood.CategoryID
order by MFoodCategory.CategoryID

select * from MFoodCategory
select * from MFood

select * from MFoodCategory
left outer join MFood on MFoodCategory.CategoryID = MFood.CategoryID

--2020/11/04

Create Table MUniversity
(UniversityID Nvarchar(32) Not NULl
,Name Nvarchar(64) Not NULl

,CONSTRAINT MUniversity_PrimaryKey PRIMARY Key CLUSTERED(UniversityID)
)
Go

Create Table MFaculty
(FacultyID Nvarchar(32) Not NULl
,FacultyName Nvarchar(64) Not NULl
,UniversityID Nvarchar(32) Not NULl

,CONSTRAINT MFaculty_PrimaryKey PRIMARY Key CLUSTERED(FacultyID)
,CONSTRAINT MFaculty_FK_UniversityID FOREIGN KEY(UniversityID)REFERENCES MUniversity(UniversityID)
)
Go

Create Table MStudent
(StudentID Nvarchar(32) Not Null
,StudentName Nvarchar(64) Not NULL
,FacultyID Nvarchar(32) Not NULl

,CONSTRAINT MStudent_PrimaryKey PRIMARY KEY CLUSTERED(StudentID)
,CONSTRAINT MStudent_FK_FacultyID FOREIGN KEY(FacultyID) REFERENCES MFaculty(FacultyID)
)
GO

insert into MUniversity VALUES('001', '東京大学')
insert into MUniversity VALUES('002', '慶応大学')
insert into MUniversity VALUES('003', '早稲田大学')
insert into MUniversity VALUES('004', '青山学院大学')
insert into MUniversity VALUES('005', '学習院大学')

select * FROM MUniversity

insert into MFaculty VALUES('001_01','文学部', '001')
insert into MFaculty VALUES('001_02','工学部', '001')
insert into MFaculty VALUES('001_03','法学部', '001')
insert into MFaculty VALUES('002_01','医学部', '002')
insert into MFaculty VALUES('002_02','理学部', '002')
insert into MFaculty VALUES('002_03','法学部', '002')
insert into MFaculty VALUES('003_01','政治経済部', '003')
insert into MFaculty VALUES('003_02','工学部', '003')
insert into MFaculty VALUES('003_03','理学部', '003')
insert into MFaculty VALUES('004_01','文学部', '004')
insert into MFaculty VALUES('004_02','経済学部', '004')
insert into MFaculty VALUES('004_03','法学部', '004')
insert into MFaculty VALUES('005_01','文学部', '005')
insert into MFaculty VALUES('005_02','法学部', '005')

select * FROM MFaculty

SELECT T1.UniversityID, T1.Name, T2.FacultyID, T2.FacultyName FROM MUniversity AS T1
INNER JOIN MFaculty AS T2 on T1.UniversityID = T2.UniversityID

INSERT INTO MStudent VALUES('00001', '田中武', '001_01')
INSERT INTO MStudent VALUES('00002', '鈴木将司', '002_01')
INSERT INTO MStudent VALUES('00003', '佐藤健太', '003_01')


SELECT T1.UniversityID, T1.Name, T2.FacultyID, T2.FacultyName,T3.StudentID, T3.StudentName 
FROM MUniversity AS T1
INNER JOIN MFaculty AS T2 on T1.UniversityID = T2.UniversityID
LEFT OUTER JOIN MStudent AS T3 on T2.FacultyID = T3.FacultyID

select StudentID,StudentName,T3.Name,FacultyName from MStudent as T1 
INNER JOIN MFaculty as T2 on T1.FacultyID = T2.FacultyID
INNER JOIN MUniversity as T3 on T2.UniversityID = T3.UniversityID






