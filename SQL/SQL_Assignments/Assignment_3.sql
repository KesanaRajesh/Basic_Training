use assignments

--Retrieve a list of MANAGERS. 
select *
from emp
where job = 'Manager'

--Find out the names and salaries of all employees earning more than 1000 per month.
select ename,sal
from emp
where sal > 1000

--Display the names and salaries of all employees except JAMES. 
select ename,sal
from emp
where ename!= 'james'

--Find out the details of employees whose names begin with ‘S’.
select *
from emp
where ename like 's%'

--Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename
from emp
where ename like '%a%'

--Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename
from emp
where ename like '__L%'

--Compute daily salary of JONES. 
select sal,sal/30 as 'Daily_Salary'
from emp
where ename like 'jones'

--Calculate the total monthly salary of all employees. 
select sum(sal) as Total_Monthly_Salary
from emp

--Print the average annual salary. 
select avg(sal*12) as annual_salary
from emp

--Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename,job,sal,deptno
from emp
where job!='salesman' and deptno = 30

--List unique departments of the EMP table. 
select distinct (deptno) as unique_departments
from emp

--List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select ename as Employee,
sal as monthly_salary
from emp 
where sal > 1500 and (deptno =10 or deptno = 30)

--Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,sal
from emp
where (job = 'analyst' or job = 'manager') and sal not in (1000,3000,5000)

--Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
select ename,sal,comm
from emp
where comm > sal*0.1

--Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782. 
select ename
from emp 
where ename like '%ll%' and deptno = 30 or mgr_id = 7782

--Display the names of employees with experience of over 30 years and under 40 yrs.
 --Count the total number of employees. 
select  ename ,count(ename) as number_of_employees  
from emp 
where datediff(year,hiredate,getdate())  between 30 and 40
group by ename

--Retrieve the names of departments in ascending order and their employees in 
--descending order. 
select d.dname,e.ename
from emp e,dept d
where e.deptno = d.deptno
order by d.dname asc, e.ename desc

--Find out experience of MILLER. 
select datediff(year,hiredate,getdate()) as employee_Experience 
from emp 
where ename = 'miller'





--write a function to calculate the area of rectangle
--create or alter function areaOfRectangle(@length int ,@breadth int)
--returns int
--as
--begin
--return(@length * @breadth)
--end

--select dbo.areaOfRectangle(2,4) as area

--select * from emp