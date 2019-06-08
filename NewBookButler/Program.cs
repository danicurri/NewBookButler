﻿using System;
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
    const int SIZE = 10;

    static void Main(string[] args)
    {
        
        Book[] books = new Book[SIZE];
        string nombreFichero = "LibrosBD.txt";

        if (!File.Exists(nombreFichero))
        {
            Console.WriteLine("No existe el fichero");
        }
        else
        {
            Cargar(nombreFichero);
        }
        
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
                    Guardar("LibrosBD.txt", books);
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
        int pages, year;
        int currentPos = 0;

        if (currentPos >= SIZE)
        {
            Console.WriteLine("Base de datos llena");
        }
        else
        {

            Console.WriteLine("Libros (ficha actual: " + currentPos + 1 + ")     "
                                        + DateTime.Now + "       Daniel Contreras 2019");

            Console.WriteLine("Título: ");
            title = Console.ReadLine();

            Pedir(title);

            Console.WriteLine("Autor: ");
            author = Console.ReadLine();

            Pedir(author);

            Console.WriteLine("Editorial: ");
            editorial = Console.ReadLine();

            Pedir(editorial);

            Console.WriteLine("Páginas: ");
            string pagesHelper = Console.ReadLine();

            Pedir(pagesHelper);

            pages = Convert.ToInt32(pagesHelper);

            Console.WriteLine("Categoría: ");
            category = Console.ReadLine();

            Pedir(category);

            Console.WriteLine("Año: ");
            string  yearHelper = Console.ReadLine();

            Pedir(yearHelper);

            year = Convert.ToInt32(yearHelper);
            
            Console.WriteLine("Ubicación: ");
            location = Console.ReadLine();

            Pedir(location);

            Console.WriteLine("Observaciones: ");
            comments = Console.ReadLine();

            Pedir(comments);

            books[currentPos].title = title;
            books[currentPos].author = author;
            books[currentPos].editorial = editorial;
            books[currentPos].pages = pages;
            books[currentPos].category = category;
            books[currentPos].year = year;
            books[currentPos].location = location;
            books[currentPos].comments = comments;

        }

        currentPos++;
        Console.WriteLine("Current:" + currentPos);
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

    public static void Guardar(string nombreFichero, Book[] books)
    {
        StreamWriter ficheroEscritura;
        int currentPos = 0;
        
        ficheroEscritura =  File.AppendText(nombreFichero);
        ficheroEscritura.WriteLine("Libros (ficha actual: " + currentPos+1  + ") " 
                                    + DateTime.Now + " Daniel Contreras 2019");
        ficheroEscritura.WriteLine("Título:     " + books[currentPos].title);
        ficheroEscritura.WriteLine("Autor:      " + books[currentPos].author);;
        ficheroEscritura.WriteLine("Editorial:  " + books[currentPos].editorial);
        ficheroEscritura.WriteLine("Páginas:    " + books[currentPos].pages);
        ficheroEscritura.WriteLine("Categoría:  " + books[currentPos].category);
        ficheroEscritura.WriteLine("Año:        " + books[currentPos].year);
        ficheroEscritura.WriteLine("Ubicación:  " + books[currentPos].location);
        ficheroEscritura.WriteLine("Observaciones: " + books[currentPos].comments);
        ficheroEscritura.WriteLine("-----------------------------------");

        currentPos++;

        ficheroEscritura.Close();

    }

    public static Book[] Cargar(string nombreFichero)
    {
        StreamReader ficheroLectura = new StreamReader(nombreFichero);

        Book[] books = new Book[SIZE];
        string linea;
        int contador = 0;

        do
        {
            linea = ficheroLectura.ReadLine();
            if (linea != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        } while (linea != null);

        Console.WriteLine("Lineas: " + contador);

        ficheroLectura.Close();

        return books;
    }
}

