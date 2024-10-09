using System;
namespace practice8
{
	public class Library
	{
		// fields
		public int Capacity;
		public int Position = 0;
		public Book[] Books;
		

		// constructor
		public Library(int capacity)
		{
			this.Capacity = capacity;

            this.Books = new Book[Capacity];
        }

		// methods
		public void AddBook(Book book)
		{
			Books[Position] = book;
			Position++;

		}

		public void DisplayBooks()
		{
			Console.WriteLine("Books in library:");
			for (int i = 0; i < Capacity; i++)
			{
				string currentBook = Books[i].Title;
				string currentAuthor = Books[i].Author;
				Console.WriteLine($"{currentBook} by {currentAuthor}");
			}
		}

    }
}

