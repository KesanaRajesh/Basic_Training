use assignments

--Write a T-SQL Program to find the factorial of a given number.
Begin Transaction t1;
Declare @i int, @a int = 9
set @i = @a - 1
while(@i > 0)
begin
set @a = @a * @i
set @i = @i - 1
end
print 'The factorial is:'+cast(@a as varchar)
commit transaction t1;

--Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 
create procedure Multiplication_Table(@number int)
AS
BEGIN
Declare @i int = 1, @result int;
while(@i <= @number)
begin
set @result = @number * @i
print 'The Multiplication table is:'+cast(@number as varchar)+'*'+cast(@i as varchar)+'='+cast(@result as varchar);
set @i = @i + 1
end
end
EXEC Multiplication_table 10

--Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly

create table student 
(
  sid int primary key,
  sname varchar(30) 
)

insert into student values (1,'jack'),
(2,'Rithvik'),
(3,'Jaspreeth'),
(4,'Praveen'),
(5,'Bisa'),
(6,'Suraj');

create table marks
(
 mid int primary key,
 sid int foreign key references student(sid),
 score int
)

insert into marks values(1,1,23),
(2,6,95),
(3,4,98),
(4,2,17),
(5,3,53),
(6,5,13);

select * from student
select * from marks;

create or alter function Student_Score (@sscore int)
returns varchar(10)
as
begin
declare @result varchar(10)
if @sscore>=50
begin
set @result='Pass'
end
else
begin
set @result='Fail'
end
return @result
end
 
select s.sid,m.mid,s.sname,m.score,dbo.Student_Score(m.score) as 'Student_Status' from student s
inner join Marks m on s.sid=m.sid order by s.sid



