use assignments


--?Write a query to display your birthday( day of week) 

DECLARE @dateofbirth 
DATE = '2001-10-17';  
     SELECT datename(weekday, @dateofbirth)
AS dayofweek;



--Write a query to display your age in days

DECLARE @birthdate DATE = '2001-10-17';  
SELECT DATEDIFF(DAY, @birthdate, GETDATE()) AS ageIndays;


--?Write a query to display all employees information those who joined before 5 years in the current month
 
--(Hint : If required update some HireDates in your EMP table of the assignment)

select * from emp
where year(getdate()) - year(hiredate) > 5
  AND month(hiredate) = month(getdate());

 


--Create table Employee with empno, ename, sal, doj columns or use and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    --c. Delete first row.
--After completing above all actions, recall the deleted row without losing increment of second row.

CREATE TABLE Employee(
empno INT PRIMARY KEY,
ename varchar(30),
sal DECIMAL(10,2),
doj DATE)
 
 BEGIN TRANSACTION
 
INSERT INTO Employee VALUES
(1, 'tharun',1000,'2024-11-03'),
(2, 'manikanta',20000,'2024-09-20'),
(3, 'rajesh',30000,'2024-08-19')
SAVE TRANSACTION p1
 
SELECT * FROM Employee
 
 

UPDATE Employee
SET sal = sal*1.15
WHERE empno = 2
 
SELECT * FROM Employee
 
SAVE TRANSACTION p2
 

DELETE FROM Employee
WHERE empno=1
 
SELECT * FROM Employee
 
ROLLBACK TRANSACTION p2
 
COMMIT
 
SELECT * FROM Employee

-- Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
	--a. For Deptno 10 employees 15% of sal as bonus.
	--b. For Deptno 20 employees  20% of sal as bonus
	--c. For Others employees 5%of sal as bonus

CREATE FUNCTION CalculateBonus (@deptno INT, @sal float)
RETURNS float
AS
BEGIN
    DECLARE @bonus float;
    IF @deptno = 10
        SET @bonus = @sal * 0.15;

    ELSE IF @deptno = 20
        SET @bonus = @sal * 0.20;

    ELSE
        SET @bonus = @sal * 0.05;

    RETURN @bonus;
END;
GO

SELECT empno,ename,sal,dbo.CalculateBonus(deptno,sal)as bonus
FROM emp



--Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)

CREATE PROCEDURE SalaryUpdation
AS
BEGIN
    UPDATE EMP
    SET Sal = Sal + 500
    WHERE Deptno=(select Deptno from DEPT where Dname='sales') and Sal<1500
END;
GO
 
EXECUTE SalaryUpdation;
  select *from Emp



