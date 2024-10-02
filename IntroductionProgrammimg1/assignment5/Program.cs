using System;

namespace assignment5;

class Program
{
    static void Main(string[] args)
    {
        // generate numbers
        //Random rnd = new Random();
        //int number1 = rnd.Next(101, 10000);

        //Random rnd2 = new Random();
        //int number2 = rnd.Next(101, 10000);

        //Random rnd3 = new Random();
        //nt number3 = rnd.Next(101, 10000);

        //Random rnd4 = new Random();
        //int number4 = rnd.Next(101, 10000);

        // add generated numbers
        //int sum = number1 + number2 + number3 + number4;




        long sum = 0;

        //int[] numbers = { 0, 0, 0, 0 };

        int amountOfNumbers = new Random().Next(1, 10000);
        int[] numbers = new int[amountOfNumbers];

        //for (int i = 0; i < 4; i++)
        //{
        //numbers[i] = new Random().Next(101, 10000);
        //sum += numbers[i];
        //Console.WriteLine($"Number{i} = {numbers[i]}");
        //}

        string calculating = "Calculating the sum = ";

        for (int i = 0; i < amountOfNumbers; i++)
        {
            numbers[i] = new Random().Next(101, 10000);
            if (i == 0)
            {
                calculating = calculating + numbers[i].ToString();
            }
            else
            {
                calculating = calculating + " + " + numbers[i].ToString();
            }

            sum += numbers[i];
        }



        // ask user to add numbers
        //Console.WriteLine($"please, add these numbers: {number1}, {number2}, {number3}, {number4}");

        //string input = Console.ReadLine();
        //int answer = int.Parse(input);

        // check the answer and give the result
        //bool result = (sum == answer);

        //Console.WriteLine(result);

        //Console.WriteLine($"The Result = {numbers[0]} + {numbers[1]} + {numbers[2]} + {numbers[3]} = {sum}");
        Console.WriteLine(calculating);
        Console.WriteLine($"The Result = {sum}");
    }
}

