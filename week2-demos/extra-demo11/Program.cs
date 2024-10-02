namespace extra_demo11;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter your password: ");
        string userPassword = Console.ReadLine();
        if (IsValidPassword(userPassword))
        {
            Console.WriteLine("Password is valid.");
        }
        else
        {
            Console.WriteLine($"Password is not valid");
        }
    }

    bool IsValidPassword(string password)
    {
        if (password.Length < 8)
        {
            // Console.WriteLine("it should be at least 8 characters long");
            return false;
        }
        else
        {
            int uppercase = 0;
            int number = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 65 && password[i] <= 90)
                {
                    uppercase += 1;
                }

                if (password[i] >= '0' || password[i] <= '9')
                {
                    number += 1;
                }
            }
            if (uppercase < 1 && number < 1)
            {
                return false;
            }
        }

        return true;
    }
}
