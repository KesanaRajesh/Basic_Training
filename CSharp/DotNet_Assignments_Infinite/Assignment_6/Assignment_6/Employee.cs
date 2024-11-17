using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public string city;
        public float employeeSalary;
    }
    class EmployeeMainClass
    {
        static void Main()
        {
            List<Employee> emp = new List<Employee>();
            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Employee {i + 1} details");
                int EmpId = int.Parse(Console.ReadLine());

                string EmpName = Console.ReadLine();
                string EmpCity = Console.ReadLine();
                float EmpSalary = Convert.ToSingle(Console.ReadLine());
                emp.Add(new Employee
                {
                    employeeId = EmpId,
                    employeeName = EmpName,
                    city = EmpCity,
                    employeeSalary = EmpSalary
                }
                  );
            }
            Console.WriteLine("Display all employees");
            foreach (var e in emp)
            {
                Console.WriteLine($"Emp Id  : {e.employeeId}, Emp Name  :   {e.employeeName}, Emp City  : {e.city}, Emp Salary  : {e.employeeSalary}");
            }

            Console.WriteLine("greater than 4500");

            var empb = emp.Where(e => e.employeeSalary > 4500).ToList();
            foreach (var e in empb)
            {
                Console.WriteLine($"Emp Id  :   {e.employeeId}, Emp Name  :   {e.employeeName}, Emp City  :   {e.city}, Emp Salary  :   {e.employeeSalary}");
            }
            Console.WriteLine("belong to banglore region");

            var empc = emp.Where(e => e.city == "banglore").ToList();
            foreach (var e in empc)
            {
                Console.WriteLine($"Emp Id  :  {e.employeeId}, Emp Name  :   {e.employeeName}, Emp City  :   {e.city}, Emp Salary  :   {e.employeeSalary}");
            }
            Console.WriteLine("in Ascending order");

            var empd = emp.OrderBy(e => e.employeeName).ToList();
            foreach (var e in empd)
            {
                Console.WriteLine($"Emp Id  :   {e.employeeId}, Emp Name  :   {e.employeeName}, Emp City  :   {e.city}, Emp Salary  :   {e.employeeSalary}");
            }
        }
    }
}

