use SEDCSecondHomework

select * from dbo.Grade

select count(Grade) as GradeCountPerTeacher
from dbo.Grade
group by TeacherID


select count(Grade) as GradeCountPerTeacherFirst100
from dbo.Grade  
where StudentID < 100
group by TeacherID

select s.FirstName, s.LastName, max(Grade) as MaxGradePerStudent
from dbo.Grade g
join 
dbo.Student s on g.ID = s.ID 
group by StudentID,s.FirstName,s.LastName

select s.FirstName, s.LastName, avg(Grade) as AverageGradePerStudent
from dbo.Grade g
join dbo.Student s on g.ID = s.ID
group by StudentID,s.FirstName,s.LastName

select count(Grade) as GradePerTeacherGreaterThan200
from dbo.Grade
group by TeacherID
having(count(Grade)) > 200

select s.FirstName,S.LastName, count(Grade) as GradeCountPerStudentFiltered
from dbo.Grade g
right join dbo.Student s on g.ID = s.ID 
group by StudentID, s.FirstName,s.LastName
having (max(Grade) = avg(Grade))

alter view vw_StudentGrades as
select s.FirstName as FirstName,s.LastName as LastName, count(Grade) as GradeCount from dbo.Grade g
join dbo.Student s on s.ID = g.StudentID
group by s.FirstName,S.LastName


select * from vw_StudentGrades
order by GradeCount desc
