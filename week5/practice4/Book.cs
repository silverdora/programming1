using System;
namespace practice4
{
	public class Book
	{
		//fields
		public string Title;
		public string Author;

		//constructor
		public Book(string title, string author)
		{
			Title = title;
			Author = author;
		}

        //methods
        public void DisplayBookInfo()
		{
			Console.WriteLine($"Book Information:\nTitle: {Title}\nAuthor: {Author}");
		}
    }
}

