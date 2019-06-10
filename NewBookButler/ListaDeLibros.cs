using System;
using System.Collections.Generic;
using System.IO;

class ListaDeLibros
{
    List<Libro> libros = new List<Libro>();
    string nombreFichero = "LibrosBD.txt";

    public int cantidad { get { return libros.Count; } }

    public ListaDeLibros()
    {
        Cargar(nombreFichero, libros, cantidad);
    }

    public Libro Get(int posicion)
    {
       Libro libro = libros[posicion - 1];
       return libro;
    }
    
    public void Incluir(Libro libro)
    {
        libros.Add(libro);
        Guardar(nombreFichero, libros, cantidad);
    }


    private static void Cargar(string nombreFichero, List<Libro> libros, int cantidad)
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


    private static void Guardar(string nombreFichero, List<Libro> libros, int cantidad)
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
}



