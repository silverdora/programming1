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
        //enter a title and author
        Console.Write("Enter book title: ");
        string bookTitle = Console.ReadLine();

        Console.Write("Enter book author: ");
        string bookAuthor = Console.ReadLine();

        Book book = new Book(bookTitle, bookAuthor);

        //display book information
        book.DisplayBookInfo();
    }
}

