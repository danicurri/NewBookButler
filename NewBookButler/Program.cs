using System;
using System.Collections.Generic;

struct Book
{
    public string title;
    public string author;
    public string editorial;
    public int pages;
    public string category;
    public int year;
    public string location;
    public string comments;
}
class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[2000];

        Console.Write("     Libros (ficha actual:  )               ");
        Console.Write(DateTime.Now);
        Console.WriteLine("             Daniel Contreras");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Title: ");
        Console.WriteLine();
        Console.WriteLine("Author: ");
        Console.WriteLine();
        Console.WriteLine("Editorial: ");
        Console.WriteLine();
        Console.WriteLine("Pages: ");
        Console.WriteLine();
        Console.WriteLine("Category: ");
        Console.WriteLine();
        Console.WriteLine("Year: ");
        Console.WriteLine();
        Console.WriteLine("Comments: ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int option;
        do
        {
            Console.Write("1.Previous   ");
            Console.Write("2.Next   ");
            Console.Write("3.Number     ");
            Console.Write("4.Search    ");
            Console.Write("5.Add     ");
            Console.WriteLine("6.Edit     ");
            Console.Write("         7.Delete    ");
            Console.Write("8-Lists    ");
            Console.Write("9.Help   ");
            Console.WriteLine("0-Exit");
            Console.WriteLine();
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 0:
                    Console.WriteLine("Thank you for your time");
                    Console.WriteLine();
                    break;

                case 1:
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                case 5:
                    Add(books);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine();
                    break;

                case 8:
                    Console.WriteLine();
                    break;

                case 9:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
            
        } while (option != 0);
    }

    //5. Add a book
    public static void Add(Book[] books)
    {
        Book b;
        string title, author, editorial, category, location, comments;
        int pages, year;

        do
        {
            Console.WriteLine("Title: ");
            title = Console.ReadLine();
            if (title == "")
            {
                Console.WriteLine("Do not leave title field empty");
            }
        } while (title == "");

        b.title = title;

        do
        {
            Console.WriteLine("Author: ");
            author = Console.ReadLine();
            if (author == "")
            {
                Console.WriteLine("Do not leave author field empty");
            }
        } while (author == "");

        b.author = author;

        do
        {
            Console.WriteLine("Editorial: ");
            editorial = Console.ReadLine();

            if (editorial == "")
            {
                Console.WriteLine("Do not leave editorial field empty");
            }
        } while (editorial == "");

        b.editorial = editorial;


        string pagesHelper;
        do
        {
            Console.WriteLine("Pages: ");
            pagesHelper = Console.ReadLine();

            if (pagesHelper == "")
            {
                Console.WriteLine("Do not leave pages field empty");
            }
        } while (pagesHelper == "");

        pages = Convert.ToInt32(pagesHelper);

        b.pages = pages;

        do
        {
            Console.WriteLine("Category: ");
            category = Console.ReadLine();

            if (category == "")
            {
                Console.WriteLine("Do not leave category field empty");
            }
        } while (category == "");

        b.category = category;

        string yearHelper;
        do
        {
            Console.WriteLine("Year: ");
            yearHelper = Console.ReadLine();

            if (yearHelper == "")
            {
                Console.WriteLine("Do not leave year field empty");
            }
        } while (yearHelper == "");

        year = Convert.ToInt32(yearHelper);

        b.year = year;

        do
        {
            Console.WriteLine("Location: ");
            location = Console.ReadLine();

            if (location == "")
            {
                Console.WriteLine("Do not leave location field empty");
            }
        } while (location == "");

        b.location = location;


        do
        {
            Console.WriteLine("Comments: ");
            comments = Console.ReadLine();

            if (comments == "")
            {
                Console.WriteLine("Do not leave comments field empty");
            }
        } while (comments == "");

        b.comments = comments;

        for (int i = 0; i < books.Length; i++)
        {
            books[i] = b;
        }
    }
}

