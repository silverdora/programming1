using static System.Formats.Asn1.AsnWriter;

namespace demo9;

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
            Console.WriteLine($"Your grade is: {CalculateGrade(score)}");
            Console.WriteLine($"Feedback: {GetGradeFeedback(score)}");
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

    string GetGradeFeedback(int score)
    {
        string grade = CalculateGrade(score);
        switch (grade)
        {
            case "A":
                return "Excellent work!";

            case "B":
                return "Good job, but there’s room for improvement.";

            case "C":
                return "You passed, but consider reviewing the material.";

            case "D":
                return "Barely passed, you should work harder.";

            case "F":
                return "Failed, please seek help.";

            default:
                return "aaa";
        }
    }
}


