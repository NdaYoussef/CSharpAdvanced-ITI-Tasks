select * from Courses


Create or alter Procedure sp_ALlStudents 
as
begin
select * from Students s
where s.CourseId = 5;
end


exec sp_ALlStudents ;

create or alter view vw_StdWithCrs
as
select c.Name as CrsName, s.Name as StudentName , s.GPA as StuGPA
from Students s join Courses c 
on s.CourseId = c.Id 

select * from dbo.vw_StdWithCrs
