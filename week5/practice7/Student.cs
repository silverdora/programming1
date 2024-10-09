using System;
namespace practice7
{
	public class Student
	{
		// fields
		public string Name;
		
		public int[] Grades;
        //private int NumberOfGrades = Grades.Length;

        // constructor
        public Student(string name, int[] grades)
		{
			this.Name = name;
			this.Grades = grades;
		}

		// methods
		private double CalculateAverage()
		{
			int sum = 0;
			for (int i = 0; i < Grades.Length; i++)
			{
				sum += Grades[i];
			}
			return (double)sum / Grades.Length;
		}

        public void DisplayGrades()
		{
			Console.WriteLine($"\nGrades for {Name}");
            for (int i = 0; i < Grades.Length; i++)
            {
				if (i == (Grades.Length - 1))
				{
					Console.WriteLine($"{Grades[i]}");
				}

				else
				{
                    Console.Write($"{Grades[i]}, ");
                }
            }
			Console.WriteLine();

            Console.WriteLine($"Average Grade: {CalculateAverage():0.00}");
        }

    }
}
