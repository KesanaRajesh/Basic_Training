create database Assessments
use assessments

create table books 
( 
id  int primary key,
title varchar(20),
author varchar(20),
isbn varchar(20) unique not null,
published_date datetime)

insert into books values
(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third SQL book', 'Cary Flint',523120967812,'2015-10-18 14:05:44')

create table reviews(
id int primary key,
book_id int not null,
reviewer_name varchar(30),
content varchar(30),
rating int,
published_date varchar(30),
foreign key(book_id) references books(id))

insert into reviews values
(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),
(2,2,'John Smith','My second review',5,'2017-10-13 15:05:12'),
(3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')

-- Write a query to fetch the details of the books written by author whose name ends with er.
SELECT *
FROM books
WHERE author LIKE '%er';

--Display the Title ,Author and ReviewerName for all the books from the above table
select title,author,reviewer_name
from books join reviews 
on 
books.id = reviews.book_id;

--Display the  reviewer name who reviewed more than one book. 
SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(*) > 1;

create table Student_details
(
Register_no int primary key,
Name varchar(30) not null,
Age int not null,
Qualification varchar(20),
Mobile_no float not null,
Mail_id varchar(30),
locationn varchar(30),
Gender varchar(1)
)
 
insert into Student_details values
(2,'Sai',22,'B.E',9952836779,'sai@gmail,com','Chennai','M'),
(3,'Kumar',20,'BSC',7252836779,'kumar@gmail,com','Madurai','M'),
(4,'Selvi',22,'B.TECH',8952836779,'selvi@gmail,com','Selam','F'),
(5,'Nisha',25,'M.E',6352836779,'nisha@gmail,com','Theni','F'),
(6,'SaiSaran',21,'B.A',9865836779,'saisaran@gmail,com','Madurai','F'),
(7,'Tom',23,'BCA',6552836779,'tom@gmail,com','Pune','M')
 
 --Write a sql server query to display the Gender,Total no of male and female from the above  
 SELECT Gender, COUNT(*) AS Total
FROM student_details
GROUP BY Gender;

create table Employee
(
Id int not null,
Ename varchar(20) not null,
Age int not null,
Addres varchar(20) not null,
Salary int
)
insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

-- Display the Names of the Employee in lower case, whose salary is null
 
select LOWER(Ename) from Employee where Salary is null

create table CUSTOMERS (
    ID int primary key,
    NAME varchar(20),
    AGE int,
    ADDRESS varchar(30),
    SALARY float
);
 
insert into CUSTOMERS VALUES
(1,'Ramesh', 32, 'Ahmedabad', 2000.00),
(2,'Khilan', 25, 'Delhi', 1500.00),
(3,'Kaushik', 23, 'Kota', 2000.00),
(4,'Chaitali', 25, 'Mumbai', 6500.00),
(5,'Hardik', 27, 'Bhopal', 8500.00),
(6,'Komal', 22, 'MP', 4500.00),
(7,'Muffy', 24, 'Indore', 10000.00);

create table ORDERS (
    OID int,
	DATE varchar(20),
	CUSTOMER_ID int,
	AMOUNT int,
	foreign key(CUSTOMER_ID) references CUSTOMERS(id)
);
 
insert into ORDERS values(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)

--Write a query to display the   Date,Total no of customer  placed order on same Date
select date,count(*) as customer_count
from orders
group by date;
 


--Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address 
select name 
from customers
where address like '%o%'





