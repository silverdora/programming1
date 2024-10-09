namespace practice7;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // enter a student's information
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter amount of grades to process: ");
        int[] grades = new int[int.Parse(Console.ReadLine())];

        Student student = new Student(name, grades);

        // enter grades
        for (int i = 0; i < student.Grades.Length; i++)
        {
            Console.Write($"Enter grade {i+1}: ");
            student.Grades[i] = int.Parse(Console.ReadLine());
        }

        // display grades
        student.DisplayGrades();
    }
}
