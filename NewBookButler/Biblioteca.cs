using System;
using System.Collections.Generic;

class Biblioteca
{
    public void Ejecutar()
    {
        int opcion;

        do
        {
            ConsolaMejorada.DibujarVentana(20, 8, 40, 8, "blue");
            ConsolaMejorada.Escribir(22, 10, "1. Gestión de libros", "yellow");
            ConsolaMejorada.Escribir(22, 11, "2. Gestión de usuarios", "yellow");
            ConsolaMejorada.Escribir(22, 12, "3. Gestión de préstamos", "yellow");
            ConsolaMejorada.EscribirCentrado(13, "0. Salir", "yellow");
            
            opcion = Convert.ToInt32(Console.ReadLine());
            // opcion = ConsolaMejorada.PedirEnteroEntreDosValores(0, 3);

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

