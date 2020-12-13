/*Sql Query to create Table1*/
create table Employee (Id int,Name varchar(50),Age int)

/*Sql Query to insert values to Table1*/
insert into Employee values(1,'AAA',25)
insert into Employee values(2,'BBB',27)
insert into Employee values(3,'CCC',26)
insert into Employee values(4,'DDD',22)
insert into Employee values(5,'EEE',28)

/*Sql Query to create Table2*/
create table EmployeeSalary (Name Varchar(50),salary Money)

/*Sql Query to insert values to Table2*/
insert into EmployeeSalary values('AAA',27000)
insert into EmployeeSalary values('BBB',30000)
insert into EmployeeSalary values('FFF',20000)
insert into EmployeeSalary values('III',21000)
insert into EmployeeSalary values('EEE',23000)

/*Sql Query to inner join*/
select Employee.Id,Employee.Name,Employee.Age,EmployeeSalary.salary from Employee 
inner join EmployeeSalary on Employee.Name=EmployeeSalary.Name

/*Sql Query to full outer join*/
select Employee.Id,Employee.Name,Employee.Age,EmployeeSalary.salary from Employee 
full outer join EmployeeSalary on Employee.Name=EmployeeSalary.Name

/*Sql Query to left outer join*/
select Employee.Id,Employee.Name,Employee.Age,EmployeeSalary.salary from Employee 
left outer join EmployeeSalary on Employee.Name=EmployeeSalary.Name

/*Sql Query to Right outer join*/
select Employee.Id,Employee.Name,Employee.Age,EmployeeSalary.salary from Employee 
Right outer join EmployeeSalary on Employee.Name=EmployeeSalary.Name


