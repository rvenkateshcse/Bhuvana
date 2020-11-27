/*Sql Query to create table*/
create table Book(Id int,Name varchar(50),Cost Money)

/*Sql Query to insert values to table*/
insert into Book values(1,'Tamil',180)
insert into Book values(2,'English',160)

/*Sql Query to select all columns table*/
select*from Book;

/*Sql Query to Delete table*/
Delete Book;

/*Sql Query to select specific columns from  table*/
select Name,Cost from Book;

/*Sql Query to select specific rows from table which satisfies condition*/
select * from Book where id>1







