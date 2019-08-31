using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClassExercise.EmployeeClass
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; }
        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = DateTime.Now;
        }
    }
}
