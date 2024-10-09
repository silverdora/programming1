namespace practice5;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // create an array of 3 people
        Person[] people = new Person[3];

        // populate the array
        for (int i = 0; i < people.Length; i++)
        {
            
            // enter name of person i
            Console.Write($"Enter a name for person {i + 1}: ");
            string name= Console.ReadLine();

            // enter age of person i
            Console.Write($"Enter age for person {i + 1}: ");
            int age = int.Parse(Console.ReadLine());

            // create person i
            people[i] = new Person(name, age);

            Console.WriteLine();
        }

        // display people
        PrintPersonArray(people);

    }

    void PrintPersonArray(Person[] persons)
    {
        for (int j = 0; j < persons.Length; j++)
        {
            Console.WriteLine($"Person {j + 1}");
            persons[j].DisplayPersonInfo();
            Console.WriteLine();
        }
    }
}