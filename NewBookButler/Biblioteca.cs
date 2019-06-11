using System;
using System.Collections.Generic;

class Biblioteca
{
    public void Ejecutar()
    {
        int opcion;

        do
        {
            Console.WriteLine("1. Gestión de libros");
            Console.WriteLine("2. Gestión de usuarios");
            Console.WriteLine("3. Gestión de préstamos");
            Console.WriteLine("0. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    GestionDeLibros gdl = new GestionDeLibros();
                    gdl.Ejecutar();
                    break;

                case 2:
                    GestionDeUsuarios gdu = new GestionDeUsuarios();
                    gdu.Ejecutar();
                    break;

                case 3:
                    GestionDePrestamos gdp = new GestionDePrestamos();
                    gdp.Ejecutar();
                    break;

                case 0:
                    Console.WriteLine("Hasta pronto");
                    break;

                default: Console.WriteLine("Opción equivocada");
                    break;
            }
        } while (opcion != 0);
    }

    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        biblioteca.Ejecutar();
    }
}

