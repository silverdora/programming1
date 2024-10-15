namespace practice1;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // enter name and age
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // create a person
        Person person1 = new Person(name, age);

        // display person's info
        person1.DisplayInfo();
    }
}

