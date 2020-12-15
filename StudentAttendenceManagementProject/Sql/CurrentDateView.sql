create view CurrentDateView as select GETDATE() as TodayDate

select*from CurrentDateview
