using System.Diagnostics.Metrics;
using System.Xml.Linq;

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
        string[] albums = new string[100];
        int numberOfAlbums = 0;

        while (true)
        {
            DisplayAlbums(albums, numberOfAlbums);
            Console.Write("Do you want to add another album? (yes/no) ");
            string answer = Console.ReadLine();
            if (answer == "no")
            {
                Console.WriteLine();
                break;
            }
            else if (answer == "yes")
            {
                Console.Write($"Enter the name of album {numberOfAlbums + 1}: ");
                albums[numberOfAlbums] = Console.ReadLine();
                numberOfAlbums++;
            }
            else
            {
                Console.WriteLine("Error: unclear answer");
                return;
            }

        }

        if (numberOfAlbums == 0)
        {
            Console.WriteLine("You don't have favorite albums");
        }
        else
        {
            Console.Write("Enter the name of the album you want to search for: ");

            string nameOfAlbum = Console.ReadLine();

            if (FindAlbum(albums, numberOfAlbums, nameOfAlbum))
            {
                Console.WriteLine($"The album {nameOfAlbum} is in your list!");
            }
            else
            {
                Console.WriteLine($"The album {nameOfAlbum} is not in your list");
            }
        }
    }

    void DisplayAlbums(string[] albums, int numberOfAlbums)
    {
        Console.WriteLine("Your favorite albums are:");
        for (int i = 0; i < numberOfAlbums; i++)
        {
            Console.WriteLine($"{i + 1}. {albums[i]}");
        }
        Console.WriteLine();
            
    }

    bool FindAlbum(string[] albums, int numberOfAlbums, string searchAlbum)
    {
        for (int i = 0; i < numberOfAlbums; i++)
        {
            if (albums[i] == searchAlbum)
            {
                return true;
            }
        }
        return false;
    }
}

