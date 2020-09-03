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

