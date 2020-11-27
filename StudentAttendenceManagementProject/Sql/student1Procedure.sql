create procedure studentprocedure 
as begin 
insert into student1(Name,Age) values('Kavi',21)
insert into Marks1(StudentId,Mark1,Mark2,Mark3) values(6,88,80,82)
end;


exec studentprocedure;