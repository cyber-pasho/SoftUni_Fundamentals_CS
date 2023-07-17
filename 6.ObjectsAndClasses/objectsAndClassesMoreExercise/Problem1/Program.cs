using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            int emplyeesCount = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();
            for (int i = 1; i <= emplyeesCount; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                Employee employee = new Employee(name, salary);
                employees.Add(employee);
                Department existingDepartment = departments.Find(d => d.Name == input[2]);
                if (existingDepartment != null)
                {
                    existingDepartment.Employees.Add(employee);
                    employee.Department = existingDepartment;
                }
                else
                {
                    Department newDepartment = new Department { Name = input[2] };
                    departments.Add(newDepartment);
                    newDepartment.Employees.Add(employee);
                    employee.Department = newDepartment;
                }
            }
            Department departmentWithHighestAverageSalary = departments.OrderByDescending(d => d.AverageSalary()).FirstOrDefault();
            if (departmentWithHighestAverageSalary != null)
            {
                Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary.Name}");
                Department sortedDepartment = new Department();
                sortedDepartment.Employees = departmentWithHighestAverageSalary.Employees.OrderByDescending(e => e.Salary).ToList();
                foreach (var employee in sortedDepartment.Employees)
                {
                    Console.WriteLine ($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
    }
    class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public decimal AverageSalary()
        {
            decimal salarySum = Employees.Sum(e => e.Salary);
            int employeesCount = Employees.Count;

            if (employeesCount > 0)
            {
                decimal averageSalary = salarySum / employeesCount;
                return averageSalary;
            }

            return 0;
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}