/*Sql Query to create table*/
create table Book(Id int,Name varchar(50),Cost Money)

/*Sql Query to insert values to table*/
insert into Book values(1,'Tamil',180)
insert into Book values(2,'English',160)
insert into Book values(3,'Maths',190)
insert into Book values(4,'Science',200)
insert into Book values(5,'Social Science',210)

/*Sql Query to select all columns from table*/
select*from Book;

/*Sql Query to Delete table*/
Delete Book;

/*Sql Query to select specific columns from  table*/
select Name,Cost from Book;

/*Sql Query to select specific rows from table which satisfies condition*/
select * from Book where id>1

/*Sql Query to return average of column*/
select AVG(cost) as AveragePrice from Book;

/*Sql Query to select Minimum value of Expression*/
select  min(cost) LowCostPrice from Book;

/*Sql Query to select Maximum value of Expression*/
select  max(cost) HighCostPrice from Book;

/*Sql Query to find sum of values*/
select sum(cost) Total from Book;

/*Sql Query to return number of rows*/
select count(Name) "No.of.books" from Book









