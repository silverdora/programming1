using System;
namespace lecture1
{
    public enum Department { SoftwareEngineering, HumanResources, Maintainance};

    public class Employee
    {
        // fields
        public string firstName, lastName;
        public Department department;
        public float salary;



		// constructor 1
		public Employee(string fisrtName, string lastName)
		{
            this.firstName = fisrtName;
            this.lastName = lastName;
        }

        // constructor 2
        public Employee(string fisrtName, string lastName,Department department)
            :this(fisrtName, lastName)
        {
            this.department = department;
            salary = 1000;
        }



        //methods
        public void IncreaseSalary(float increase)
		{
			salary += increase;
		}

        public void DisplayEmployee()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {salary:0.00}");
        }
    }
}

