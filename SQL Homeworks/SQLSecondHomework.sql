use SEDCSecondHomework
go

Select * from dbo.Student
where FirstName = 'Antonio'
go

Select * from dbo.Student
where DateOfBirth > '01.01.1999'
go

select * from dbo.Student
where LastName like 'J%'
intersect
select * from dbo.Student
where EnrolledDate >= '1998.01.01' and EnrolledDate <= '1998.01.31'
go

select * from dbo.Student
order by FirstName
go

select LastName from dbo.Student
union
select LastName from dbo.Teacher
go

select * from Course c
join AchievementType act on act.ID = c.ID
order by c.Name,act.Name

select * from dbo.Teacher t
left join dbo.Grade g on t.ID = g.TeacherID
where g.Grade is null
order by t.FirstName, t.LastName	
