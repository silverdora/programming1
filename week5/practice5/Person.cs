using System;
namespace practice5
{
	public class Person
	{
		// fields
		public string Name;
		public int Age;

		// constructor 
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

        // methods
        public void DisplayPersonInfo()
		{
			Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Age: {this.Age}");
        }

    }
}

