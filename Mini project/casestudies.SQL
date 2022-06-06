create database casestudies
use casestudies

create table tblCourse
(CourseId int primary key,CourseName varchar(30), Courseduration int, Coursefees float)

insert into tblCourse values(10,'Power BI',20,25000),(20,'Python',40,40000),
(30,'Java',60,55000),(40,'Azure',80,68000)

select * from tblCourse;


create table tblStudent
(StudentId int primary key, StudentName varchar(30), StudentDOB date)

insert into tblStudent values(201,'swami','05/14/1997'),(202,'sumanth','07/23/1999'),
(203,'madhu','09/25/2001'),(204,'jagan','12/27/2004')

select * from tblStudent;

create table tblEnrollDetails
( StudentId int foreign key references  tblStudent(StudentId),
CourseId int foreign key references tblCourse(CourseId),
EnrollDate date)

insert into tblEnrollDetails values (201,10,'2022/05/13'),(202,20,'2022/05/15'),
(203,30,'2022/05/17'),(204,40,'2022/05/20')

select * from tblEnrollDetails;

select * from tblCourse;
select * from tblStudent;
select * from tblEnrollDetails;