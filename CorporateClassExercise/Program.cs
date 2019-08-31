using System;
using System.Collections.Generic;
using CorporateClassExercise.EmployeeClass;

namespace CorporateClassExercise
{
    class Program
    {
        public class Company
        {
            public string Name { get; }
            public DateTime CreatedOn { get; }

            public List<Employee> _currentEmployees = new List<Employee>();

            public void AddEmployee(Employee employee)
            {
                _currentEmployees.Add(employee);
            }

            public void FireEmployee(Employee employee)
            {
                _currentEmployees.Remove(employee);
            }

            public void ListEmployees()
            {
                foreach (Employee employee in _currentEmployees )
                {
                    Console.WriteLine($"{employee.FirstName} is a {employee.JobTitle} at {Name}");
                }
            }
            public Company(string name)
            {
                Name = name;
                CreatedOn = DateTime.Now;
            }
        }
        static void Main(string[] args)
        {
            var company = new Company("PoopScoop Incorporated");
            var employee1 = new Employee("John", "Smith", "Data Analyst");
            var employee2 = new Employee("Janice", "Griffin", "Boss of All");
            var employee3 = new Employee("Jeff", "Tweedy", "Coffee Bitch");
            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);
            company.ListEmployees();
            employee1.eat();
            employee1.eat();
            employee1.eat();
            employee1.eat();
            employee1.eat();
            employee1.eat(company._currentEmployees);
            employee2.eat("Chicken");
            employee3.eat("Steak", company._currentEmployees);


        }
    }
}
