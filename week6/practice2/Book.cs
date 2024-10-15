using System;
using System.Xml.Linq;

namespace practice2
{
	public class Book
	{
       // properties
        public string Title{ get; }
        public string Author { get; set; }

        //constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        //methods
        public void DisplayBookInfo()
        {
            Console.WriteLine($"\nBook Details:\n" +
                $"Title: {Title}\n" +
                $"Author: {Author}");
        }
    }
}