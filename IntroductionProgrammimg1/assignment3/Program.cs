using System;
// using System.Collections.Generic;

namespace assignment3;

class Program
{
    static void Main(string[] args)
    {
        // read first name of user
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        // read last name of user
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        // display full name (option 1)
        Console.WriteLine("Your full name is " + firstName + " " + lastName);

        // display full name (option 2)
        Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

        // display full name (option 3 - string interpolation)
        Console.WriteLine($"Your full name is {firstName} {lastName}");

        // wait for the user to enter a key
        Console.ReadKey();

    }
}

