using System;

namespace assignment1;

class Program
{
    static void Main(string[] args)
    {
        // variable 'name' is declared here
        string name;

        // read the name of the user and save it in variable 'name'
        name = Console.ReadLine();

        // read the age of the user and save it in variable 'age'
        // (variable 'age' is declared here and immediately given a value)
        string age = Console.ReadLine();

        // display name and age
        Console.Write("Your name is " + name);
        Console.WriteLine("Your age is " + age);


        // wait for the user to enter a key
        Console.ReadKey();
    }
}

