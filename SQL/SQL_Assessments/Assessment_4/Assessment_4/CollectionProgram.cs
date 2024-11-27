using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_4
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class CollectionProgram
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 06, 08), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1994, 08, 20), DOJ = new DateTime(2012, 07, 07), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 04, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016, 02, 02), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016, 02, 02), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014, 08, 08), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 02), DOJ = new DateTime(2015, 06, 01), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 06), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014, 12, 03), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 04, 12), DOJ = new DateTime(2016, 01, 02), City = "Pune" },
        };
            
            Console.WriteLine("Question_1");
            var allEmployees = employeeList;
            Console.WriteLine("Employee Details: ");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title} {emp.DOB.ToShortDateString()} {emp.DOJ.ToShortDateString()} {emp.City}");
            }

            
            Console.WriteLine("Question_2");
            var nonMumbaiEmployees = employeeList.Where(e => e.City != "Mumbai");
            Console.WriteLine("Employees Not in Mumbai:");
            foreach (var emp in nonMumbaiEmployees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.City}");
            }

            
            Console.WriteLine("Question_3");
            var asstManagers = employeeList.Where(e => e.Title == "AsstManager");
            Console.WriteLine("AsstManagers:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title}");
            }

            
            Console.WriteLine("Question_4");
            var employeesWithS = employeeList.Where(e => e.LastName.StartsWith("S"));
            Console.WriteLine(" Name Starts with 'S':");
            foreach (var emp in employeesWithS)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName}");
            }
            Console.ReadLine();
        }
    }
}
   
