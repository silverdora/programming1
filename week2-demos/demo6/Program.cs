using static System.Formats.Asn1.AsnWriter;

namespace demo6;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter your score (0-100): ");
        int score = int.Parse(Console.ReadLine());
        if (score < 0 || score > 100)
        {
            Console.WriteLine("Invalid input. Please enter a valid score.");
        }
        else
        {
            Console.WriteLine($"Your grade is {CalculateGrade(score)}");
        }
    }

    string CalculateGrade(int score)
    {
        string grade = "";
        if (score >= 90 && score <= 100)
        {
            grade = "A";
        }
        else if (score >= 80 && score < 90)
        {
            grade = "B";
        }
        else if (score >= 70 && score < 80)
        {
            grade = "C";
        }
        else if (score >= 60 && score < 70)
        {
            grade = "D";
        }
        else if (score >= 0 && score < 60)
        {
            grade = "F";
        }
        return grade;
    }
}