using System;
namespace practice1
{
	public class Person
	{
		// fields
		private string _name;
		private int _age;


		// properties
		public string Name
		{
			get{ return _name; }

			set { _name = value; }
		}

        public int Age
        {
            get{ return _age; }
			set { _age = value; }
        }


		// constructor
        public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		//methods
		public void DisplayInfo()
		{
			Console.WriteLine(); //empty line
			Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
	}
}

