using System.Diagnostics.Metrics;

namespace practice8;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // enter library capacity
        Console.Write("How many books should there be in the library: ");
        int capacity = int.Parse(Console.ReadLine());

        // create and fill library
        Library collection = new Library(capacity);
        for (int i = 0; i < capacity; i++)
        {
            Console.Write("Enter book title: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Enter book author: ");
            string bookAuthor = Console.ReadLine();

            Book book = new Book(bookTitle, bookAuthor);
            collection.AddBook(book);

            Console.WriteLine();
        }

        // display book in library
        collection.DisplayBooks();
    }
}

