using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClassExercise.EmployeeClass
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; }
        List<string> _restaurants = new List<string>(new string[] { "BJ's Hot Chicken", "Thai Papaya", "Murff's Burgers" });
        public Employee(string firstName, string lastName, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            StartDate = DateTime.Now;
        }

        string RandomRestaurant()
        {
            Random random = new Random();
            var randomNum = random.Next(0, _restaurants.Count);
            var restaurantChoice = _restaurants[randomNum];
            return restaurantChoice;
        }

        string ListEmployees(List<Employee> companions)
        {
            var stringOfEmployees = "";
            for(var i = 0; i < companions.Count; i ++)
            {
                if (i == 0)
                {
                    stringOfEmployees += companions[i].FirstName;

                }
                else if (i == companions.Count - 1)
                {
                    stringOfEmployees += $" and {companions[i].FirstName}";
                }
                else
                {
                    stringOfEmployees += $", {companions[i].FirstName}";
                }
            }
            return stringOfEmployees;
        }
        public void eat()
        {
            var restaurantChoice = RandomRestaurant();
            Console.WriteLine($"{FirstName} ate at {restaurantChoice}");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office");
        }

        public void eat(List<Employee> companions)
        {
            var restaurantChoice = RandomRestaurant();
            var listOfEmployees = ListEmployees(companions);
            Console.WriteLine($"{FirstName} is eating at {restaurantChoice} with {listOfEmployees}");
        }

        public void eat(string food, List<Employee> companions)
        {
            var listOfEmployees = ListEmployees(companions);
            Console.WriteLine($"{FirstName} ordered {food} with {listOfEmployees}");

        }
    }
}
