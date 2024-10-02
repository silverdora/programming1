using System.Diagnostics;

namespace demo10;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a letter: ");
        string input = Console.ReadLine();

        if (input.Length != 1)
        {
            Console.WriteLine($"Error: {input} is not a letter.");
            return;
        }
        char testedInput = char.Parse(input.ToLower());

        if ((testedInput < 97 || testedInput > 122))
        {
            Console.WriteLine($"Error: {input} is not a letter.");
        }
        else
        {
            if (IsLetterVowel(testedInput))
            {
                Console.WriteLine($"{input} is a vowel");
            }
            else
            {
                Console.WriteLine($"{input} is a consonant");
            }
        }
    }

    bool IsLetterVowel(char letter)
    {
        switch (letter)
        {
            case 'a':
                return true;

            case 'e':
                return true;

            case 'i':
                return true;

            case 'o':
                return true;

            case 'u':
                return true;

            default:
                return false;
        }
    }
}
