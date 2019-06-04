using System;
using System.Collections.Generic;
using System.IO;

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
    const int SIZE = 2000;

    static void Main(string[] args)
    {
        
        Book[] books = new Book[SIZE];

        Console.Write("     Libros (ficha actual:  )               ");
        Console.Write(DateTime.Now);
        Console.WriteLine("             Daniel Contreras");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Título: ");
        Console.WriteLine();
        Console.WriteLine("Autor: ");
        Console.WriteLine();
        Console.WriteLine("Editorial: ");
        Console.WriteLine();
        Console.WriteLine("Páginas: ");
        Console.WriteLine();
        Console.WriteLine("Categoría: ");
        Console.WriteLine();
        Console.WriteLine("Año: ");
        Console.WriteLine();
        Console.WriteLine("Ubicación");
        Console.WriteLine();
        Console.WriteLine("Observaciones: ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        int option;
        do
        {
            Console.Write("1.Anterior   ");
            Console.Write("2.Posterior   ");
            Console.Write("3.Número     ");
            Console.Write("4.Búsqueda    ");
            Console.Write("5.Añadir     ");
            Console.WriteLine("6.Modificar     ");
            Console.Write("         7.Borrar    ");
            Console.Write("8-Listados    ");
            Console.Write("9.Ayuda   ");
            Console.WriteLine("0-Terminar");
            Console.WriteLine();
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 0:
                    Console.WriteLine("Hasta la próxima");
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
                    Console.WriteLine("Opción errónea");
                    Console.WriteLine();
                    break;
            }
            
        } while (option != 0);
    }

    //5. Add a book
    public static void Add(Book[] books)
    {
        string title, author, editorial, category, location, comments;
        int pages, year, currentPos = 0;

        if (currentPos >= SIZE)
        {
            Console.WriteLine("Base de datos llena");
        }
        else
        {   
            Console.WriteLine("Título: ");
            title = Console.ReadLine();

            Pedir(title);
            
            books[currentPos].title = title;

            Console.WriteLine("Autor: ");
            author = Console.ReadLine();

            Pedir(author);

            books[currentPos].author = author;

            Console.WriteLine("Editorial: ");
            editorial = Console.ReadLine();

            Pedir(editorial);

            books[currentPos].editorial = editorial;

            Console.WriteLine("Páginas: ");
            string pagesHelper = Console.ReadLine();

            Pedir(pagesHelper);

            pages = Convert.ToInt32(pagesHelper);

            books[currentPos].pages = pages;

            Console.WriteLine("Categoría: ");
            category = Console.ReadLine();

            Pedir(category);

            books[currentPos].category = category;

            Console.WriteLine("Año: ");
            string  yearHelper = Console.ReadLine();

            Pedir(yearHelper);

            year = Convert.ToInt32(yearHelper);

            books[currentPos].year = year;
            
            Console.WriteLine("Ubicación: ");
            location = Console.ReadLine();

            Pedir(location);

            books[currentPos].location = location;

            Console.WriteLine("Observaciones: ");
            comments = Console.ReadLine();

            Pedir(comments);

            books[currentPos].comments = comments;

            Guardar(title, author, editorial, pages,
                    category, year, location, comments);
        }

        currentPos++;

    }

    public static void Pedir(string cadena)
    {
        do
        {
            if (cadena == "")
            {
                Console.WriteLine("No deje el campo vacío");
            }
        } while (cadena == "");
    }

    public static void Guardar(string titulo, string autor, string editorial,
                                int paginas, string categoria, int anyo,
                                string ubicacion, string observaciones)
    {
        StreamWriter ficheroEscritura;

        string nombreFichero = "LibrosBD.txt";

        ficheroEscritura = File.AppendText(nombreFichero);
        ficheroEscritura.Write(DateTime.Now + " - ");
        ficheroEscritura.WriteLine(titulo, autor, editorial, paginas, categoria, anyo,
                                ubicacion, observaciones + " ");

        ficheroEscritura.Close();
    }
}

