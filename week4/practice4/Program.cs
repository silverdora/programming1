namespace practice4;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter course name: ");
        string courseName = Console.ReadLine();

        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        string[] namesOfStudens = new string[numberOfStudents];
        ReadNames(namesOfStudens);

        Console.Write("\n");

        int[] gradesOfStudens = new int[numberOfStudents];
        ReadGrades(gradesOfStudens, namesOfStudens);

        int indexOfHighestGrade = GetHighestGradeIndex(gradesOfStudens);

        Console.WriteLine($"Student {namesOfStudens[indexOfHighestGrade]} " +
            $"has the highest grade: {gradesOfStudens[indexOfHighestGrade]}");

        

    }

    void ReadNames(string[] names)
    {
        for (int i = 1; i <= names.Length; i++)
        {
            Console.Write($"Enter name of student {i}: ");
            names[i - 1] = Console.ReadLine();
        }
    }

    void ReadGrades(int[] grades, string[] names)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter grade of student {names[i]}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
    }

    int GetHighestGradeIndex(int[] grades)
    {
        int highestGrade = 0;
        int index = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > highestGrade)
            {
                highestGrade = grades[i];
                index = i;
            }
        }
        return index;
    }
}
