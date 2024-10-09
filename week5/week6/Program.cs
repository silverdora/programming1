namespace lecture1;

internal class Program
{

    // when use static, don't need to create an instance of class
    static void Main(string[] args)
    {
        //Program program = new Program();
        Program.Start();
    }

    static void Start()
    {
        // create and employee object (instance of class Employee)
        Employee employee1 = new Employee("Kevin", "Armstrong", Department.SoftwareEngineering);
        employee1.salary = 2500;

        employee1.IncreaseSalary(2000);

        Employee employee2 = new Employee("Sarah", "Konnor", Department.HumanResources);
        //employee2.salary = 4000;

        //Employee employee3 = new Employee();

        employee1.DisplayEmployee();
        Console.WriteLine();
        employee2.DisplayEmployee();
    }

    
}

