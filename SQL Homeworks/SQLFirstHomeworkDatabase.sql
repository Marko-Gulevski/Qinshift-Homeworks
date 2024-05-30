create database SEDCFirstHomework
go
use SEDCFirstHomework

create table Student (
Id int Identity(1,1) primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
DateOfBirth date null,
EnrolledDate date null,
Gender nchar null,
NationalIdNumber bigint null,
StudentCardNumber nvarchar(100) null
)

create table Teacher (
Id int Identity(1,1) primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
DateOfBirth date null,
AcademicRank nvarchar(100) not null,
HireDate date null
)

create table Grade (
Id int Identity(1,1) primary key,
StudentID int null,
CourseID int null,
TeacherID int null,
Grade tinyint null,
Comment nvarchar(max) null,
CreatedDate date null
)

create Table Course (
Id int Identity(1,1) primary key,
[Name] nvarchar(100) not null,
Credit tinyint null,
AcademicYear tinyint null,
Semester tinyint null
)

create Table GradeDetails (
Id int Identity(1,1) primary key,
GradeID int null,
AchievementTypeID int null,
AchievementPoints smallint null,
AchievementMaxPoint smallint null,
AchievementDate date null
)

create table AchievementType (
Id int Identity(1,1) primary key,
[Name] nvarchar(100) not null,
[Description] nvarchar(max) not null,
ParticipationRate int null
)