create table Marks1 (StudentId int foreign key references student1(Id), Mark1 int,Mark2 int,Mark3 int);

insert into Marks1 values(1,88,87,80)
insert into Marks1 values(2,89,87,70)
insert into Marks1 values(3,81,85,80)
insert into Marks1 values(4,80,87,83)
insert into Marks1 values(5,87,87,80)



select*from Marks1