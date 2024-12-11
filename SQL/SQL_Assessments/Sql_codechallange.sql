use assessments

create table Coursedetails
(
  C_id varchar(30),
  C_name varchar(30),
  Startdate date,
  End_date date,
  Fee float

)
insert into Coursedetails values
('DN003','DotNet','2018-02-01','2018-02-28',15000),
('DV004','DataVisualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),
('JC001','CoreJava','2018-01-02','2018-01-12',3000);

select * from coursedetails

--Create a Function to calculate the course duration for the above relation by receiving start date and end date as input.
create function CourseDuration(@startdate date,@enddate date)
returns int
as
begin
return (@enddate - @startdate)
end 
go

select C_id,C_Name,fee,dbo.CourseDuration(Startdate,End_date) as Courese_Duration_In_Days from CourseDetails

--Create a trigger to display the Course Name and Start date of the course
--(note: when ever the new course is entered in course details relation , Course Name and Start date should get reflected  in T_CourseInfo table)
create table T_CourseInfo
(
    CourseName VARCHAR(60),
    StartDate DATE
);
 
create trigger trg_dispaly
on Coursedetails
after insert
as
begin
    
    INSERT INTO T_CourseInfo (CourseName, StartDate)
    SELECT C_Name, Startdate
    FROM INSERTED;
END;
GO
 

INSERT INTO Coursedetails (C_id, C_Name, Startdate, End_date, Fee)
VALUES ('WD003', 'web development', '2024-11-20', '2024-12-15', 25000);

 
SELECT * FROM T_CourseInfo;



--Write a stored Procedure that inserts records in the ProductsDetails table
 
--Table : ProductsDetails (ProductId, ProductName, Price, DiscountedPrice)
 
--The procedure should generate the ProductId automatically to insert and should return the generated value to the user
--Hint(User should not give the ProductId while inserting)
--Also the Discounted Price Column is a calculated column (Price - 10%)




CREATE TABLE ProductDetails(
ProductID INT IDENTITY(1,1),
ProductName VARCHAR(20),
Price INT,
DiscountedPrice as (Price*0.90)
)
 
CREATE PROCEDURE DetailsInsert @ProductName VARCHAR(25), 
@Price INT, @ProductID INT OUTPUT as
BEGIN
INSERT INTO ProductDetails(ProductName, Price) VALUES(@ProductName,@Price)
SET @ProductID = SCOPE_IDENTITY()
END
 
DECLARE @NewProductID INT
EXEC DetailsInsert
@ProductName = 'Phone',
@Price = 10000,
@ProductID = @NewProductID OUTPUT
 
SELECT @NewProductID as ProductID
SELECT * FROM ProductDetails






