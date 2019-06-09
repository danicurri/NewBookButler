using System;
using System.Collections.Generic;
using System.IO;
/*
struct Libro
{
    public string titulo;
    public string autor;
    public string editorial;
    public int paginas;
    public string categoria;
    public int anyo;
    public string ubicacion;
    public string observaciones;
}
*/
class BookButler
{
    const int SIZE = 10;

    static void Main(string[] args)
    {

        Libro[] libros = new Libro[SIZE];
        int posActual = 0;
        int numeroDeLibroAMostrar = 0;
        string nombreFichero = "LibrosBD.txt";

        if (!File.Exists(nombreFichero))
        {
            Console.WriteLine("No existe el fichero");
        }
        else
        {
            Cargar(nombreFichero, libros, ref posActual);
        }

        int opcion;
        do
        {
            Console.WriteLine("Libros (ficha actual: " + (numeroDeLibroAMostrar + 1) + ")     "
                + DateTime.Now + "       Daniel Contreras 2019");
            Console.WriteLine();
            Mostrar(libros, posActual, numeroDeLibroAMostrar);

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
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Hasta la próxima");
                    Guardar("LibrosBD.txt", libros, posActual);
                    Console.WriteLine();
                    break;

                case 1:
                    if (numeroDeLibroAMostrar > 0)
                        numeroDeLibroAMostrar--;
                    Console.WriteLine();
                    break;

                case 2:
                    if (numeroDeLibroAMostrar < posActual - 1)
                        numeroDeLibroAMostrar++;
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine();
                    break;

                case 5:
                    Anyadir(libros, ref posActual);
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

        } while (opcion != 0);

    }

    //5. Add a book
    public static void Anyadir(Libro[] libros, ref int posActual)
    {
        string titulo, autor, editorial, categoria, ubicacion, observaciones;
        int paginas, anyo;

        if (posActual >= SIZE)
        {
            Console.WriteLine("Base de datos llena");
        }
        else
        {
            //  función "Pedir y devolver"
            titulo = PedirYDevolver("Título: ");
            autor = PedirYDevolver("Autor: ");
            editorial = PedirYDevolver("Editorial: ");
            paginas =  Convert.ToInt32(PedirYDevolver("Páginas: "));
            categoria = PedirYDevolver("Categoría: ");
            anyo = Convert.ToInt32(PedirYDevolver("Año: "));
            ubicacion = PedirYDevolver("Ubicación: ");
            observaciones = PedirYDevolver("Observaciones: ");

            libros[posActual].titulo = titulo;
            libros[posActual].autor = autor;
            libros[posActual].editorial = editorial;
            libros[posActual].paginas = paginas;
            libros[posActual].categoria = categoria;
            libros[posActual].anyo = anyo;
            libros[posActual].ubicacion = ubicacion;
            libros[posActual].observaciones = observaciones;

        }

        posActual++;
        Console.WriteLine(
            );
        Console.WriteLine("Posicion actual:" + posActual);
    }


    // muestra libro
    public static void Mostrar(Libro[] libros, int posActual, int numeroDeLibro)
    {
        if (numeroDeLibro < posActual)
        {
            Console.WriteLine(libros[numeroDeLibro].titulo);
            Console.WriteLine(libros[numeroDeLibro].autor);
            Console.WriteLine(libros[numeroDeLibro].editorial);
            Console.WriteLine(libros[numeroDeLibro].paginas);
            Console.WriteLine(libros[numeroDeLibro].categoria);
            Console.WriteLine(libros[numeroDeLibro].anyo);
            Console.WriteLine(libros[numeroDeLibro].ubicacion);
            Console.WriteLine(libros[numeroDeLibro].observaciones);
            Console.WriteLine();
        }
    }

    // Mejora 1: versión sobre cargada que da más pasos,
    // realmente pide datos y los devuelve
    public static string PedirYDevolver(string aviso)
    {
        Console.WriteLine(aviso);
        string respuesta;
        do
        {
            respuesta = Console.ReadLine();
            if (respuesta == "")
            {
                Console.WriteLine("No deje el campo vacío");
            }
        } while (respuesta == "");
        return respuesta;
    }


    public static void Guardar(string nombreFichero, Libro[] libros, int cantidad)
    {
        StreamWriter ficheroEscritura;
        try
        {
            ficheroEscritura = File.CreateText(nombreFichero);
            //ficheroEscritura.WriteLine(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                ficheroEscritura.WriteLine("Libro " + (i + 1) + ":");
                ficheroEscritura.WriteLine("Título: " + libros[i].titulo);
                ficheroEscritura.WriteLine("Autor: " + libros[i].autor); ;
                ficheroEscritura.WriteLine("Editorial: " + libros[i].editorial);
                ficheroEscritura.WriteLine("Páginas: " + libros[i].paginas);
                ficheroEscritura.WriteLine("Categoría: " + libros[i].categoria);
                ficheroEscritura.WriteLine("Año: " + libros[i].anyo);
                ficheroEscritura.WriteLine("Ubicación: " + libros[i].ubicacion);
                ficheroEscritura.WriteLine("Observaciones: " + libros[i].observaciones);
                ficheroEscritura.WriteLine("-----------------------------------------");
            }
            ficheroEscritura.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine("No se ha podido escribir!");
            Console.WriteLine("El error exacto es: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Problema general(fichero escritura): " + e.Message);
        }
    }


    public static void Cargar(string nombreFichero, Libro[] libros, ref int cantidad)
    {
        StreamReader ficheroLectura = new StreamReader(nombreFichero);

        try
        {

            cantidad = Convert.ToInt32(ficheroLectura.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                libros[i].titulo = ficheroLectura.ReadLine();
                libros[i].autor = ficheroLectura.ReadLine();
                libros[i].editorial = ficheroLectura.ReadLine();
                libros[i].paginas = Convert.ToInt32(ficheroLectura.ReadLine());
                libros[i].categoria = ficheroLectura.ReadLine();
                libros[i].anyo = Convert.ToInt32(ficheroLectura.ReadLine());
                libros[i].ubicacion = ficheroLectura.ReadLine();
                libros[i].observaciones = ficheroLectura.ReadLine();

            }
            ficheroLectura.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine("No se ha podido escribir!");
            Console.WriteLine("El error exacto es: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Problema general(fichero lectura): " + e.Message);
        }
    }
}
