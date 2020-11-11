CREATE TABLE DBook
(BookName Nvarchar(100) Not NULL
,Author Nvarchar(100) Not NULL
,Price Int Not NULL
,PublishedDate DATE Not NULL
)
GO

select * from DBook

insert into DBook values ('Harry Potter and the Philosophers Stone','J.K.Rowling',1158,'1997/06/26')
insert into DBook values ('Alex Rider Storm Breaker','Anthony Horowitz',1513,'2000/09/04')
insert into DBook values('A Game of Thrones: A Song of Ice and Fire','George R. R. Martin',7589,'2012/5/29')
insert into DBook values('Dont Sweat the Small Stuff and Its All Small Stuff','Richard Carlson',1573,'1997/1/1')

SELECT * from DBook

insert into DBook values('The Hunger Games','Suzanne Collins',1508,'2010/07/03')

update DBook 
set BookName = 'A Game of Thrones'
where Price = 7589


