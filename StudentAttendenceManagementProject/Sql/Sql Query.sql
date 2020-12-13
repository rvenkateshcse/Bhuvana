/*Sql Query to get today date*/
select GETDATE() as TodayDate

/*Sql Query to convert dd-mm-yyyy to yyyy-mm-dd*/
declare  @Date varchar(10)='09-12-2020'
select CONVERT(date,@Date,103)

/*Sql Query to find largest of three numbers */
declare @a int =10;
declare @b int =30;
declare @c int =40;
if(@a>@b)and (@a>@c)
print'a is greater'
else if(@b>@a)and (@b>@c)
print'b is greater'
else
print 'c is greater'




