using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Class1
    {
        public class Employee
        {
            int empId;
            String empName;
            float salary;
            public Employee(int empid, String empname, float salary)
            {
                this.empId = empid;
                this.empName = empname;
                this.salary = salary;
                Console.WriteLine("Parent class constructor:");
                Console.WriteLine("The Empid is:" + empId);
                Console.WriteLine("The Empname is:" + empName);
                Console.WriteLine("The Salary is:" + salary);
                Console.WriteLine("**************************");
            }
        }
        public class PartTimeEmployee : Employee
        {
            int Wages;
            
            public PartTimeEmployee(int empid, String empname, float salary) : base(empid, empname, salary)
            {
                Console.WriteLine("Derived class constructor:");
            }
            public static void Main(String[] args)
            {
                int empid;
                String empname;
                float salary;
                Console.WriteLine("Enter the employee id:");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the employee name:");
                empname = (Console.ReadLine());
                Console.WriteLine("Enter the employee salary:");
                salary = Convert.ToSingle(Console.ReadLine());
                PartTimeEmployee partTimeEmployee = new PartTimeEmployee(empid, empname, salary);
                Console.Read();




            }
        }
    }
    
}

