using System;

namespace assignment2;

class Program
{
    static void Main(string[] args)
    {
        // read age of user
        Console.Write("Enter your age ");
        //string input = Console.ReadLine();

        // convert text to an integer value (int)
        int age = int.Parse(Console.ReadLine()) + 1;

        // now we can perform some (arithmetic) operations on the (int) age
        // (which are not possible on the string value!)
        //age ++;

        // convert integer value to text
        //string output = age.ToString();

        // display the increased age
        Console.WriteLine("Next year you will be " + age.ToString()+ " years old.");

        // wait for the user to enter a key
        Console.ReadKey();
    }
}

