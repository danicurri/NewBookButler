using System;
using System.Collections.Generic;
using System.IO;

class ListaDeLibros
{
    List<Libro> libros;
    string nombreFichero = "LibrosBD.txt";

    public int Cantidad { get { return libros.Count; } }

    public ListaDeLibros()
    {
        libros = new List<Libro>();
        Cargar(nombreFichero);
    }

    public Libro Get(int posicion)
    {
        Libro libro = libros[posicion];
        return libro;
    }

    public void Incluir(Libro libro)
    {
        libros.Add(libro);
        Guardar(nombreFichero);
    }


    private void Cargar(string nombreFichero)
    {
        if (!File.Exists(nombreFichero))
            return;

        try
        {
            StreamReader ficheroLectura = new StreamReader(nombreFichero);

            int cantidad = Convert.ToInt32(ficheroLectura.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                string titulo = ficheroLectura.ReadLine();
                string autor = ficheroLectura.ReadLine();
                string editorial = ficheroLectura.ReadLine();
                int paginas = Convert.ToInt32(ficheroLectura.ReadLine());
                string categoria = ficheroLectura.ReadLine();
                int anyo = Convert.ToInt32(ficheroLectura.ReadLine());
                string ubicacion = ficheroLectura.ReadLine();
                string observaciones = ficheroLectura.ReadLine();
                string codigo = ficheroLectura.ReadLine();

                libros.Add(new Libro(titulo, autor, editorial,
                    paginas, categoria, anyo, ubicacion, observaciones,
                    codigo));

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


    private void Guardar(string nombreFichero)
    {
        StreamWriter ficheroEscritura;
        try
        {
            ficheroEscritura = File.CreateText(nombreFichero);
            ficheroEscritura.WriteLine(libros.Count);
            for (int i = 0; i < Cantidad; i++)
            {
                ficheroEscritura.WriteLine(libros[i].titulo);
                ficheroEscritura.WriteLine(libros[i].autor); ;
                ficheroEscritura.WriteLine(libros[i].editorial);
                ficheroEscritura.WriteLine(libros[i].paginas);
                ficheroEscritura.WriteLine(libros[i].categoria);
                ficheroEscritura.WriteLine(libros[i].anyo);
                ficheroEscritura.WriteLine(libros[i].ubicacion);
                ficheroEscritura.WriteLine(libros[i].observaciones);
                ficheroEscritura.WriteLine(libros[i].codigo);
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
