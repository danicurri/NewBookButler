using System;

class GestionDeLibros
{
    public void Ejecutar()
    {
        ListaDeLibros libros = new ListaDeLibros();
        int posActual = 0;
        int numeroDeLibroAMostrar = 0;

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
    public static void Anyadir(ListaDeLibros libros, ref int posActual)
    {
        string titulo, autor, editorial, categoria, ubicacion,
            observaciones, codigo;
        int paginas, anyo;

        //  función "Pedir y devolver"
        codigo = PedirYDevolver("Código: ");
        titulo = PedirYDevolver("Título: ");
        autor = PedirYDevolver("Autor: ");
        editorial = PedirYDevolver("Editorial: ");
        paginas = Convert.ToInt32(PedirYDevolver("Páginas: "));
        categoria = PedirYDevolver("Categoría: ");
        anyo = Convert.ToInt32(PedirYDevolver("Año: "));
        ubicacion = PedirYDevolver("Ubicación: ");
        observaciones = PedirYDevolver("Observaciones: ");

        libros.Incluir(new Libro(titulo, autor, editorial,
                    paginas, categoria, anyo, ubicacion, observaciones,
                    codigo));

        posActual++;
        Console.WriteLine();
        Console.WriteLine("Posicion actual:" + posActual);
    }


    // muestra libro
    public static void Mostrar(ListaDeLibros libros,
        int posActual, int numeroDeLibro)
    {
        if (numeroDeLibro < libros.Cantidad)
        {
            Console.WriteLine(libros.Get(numeroDeLibro).titulo);
            Console.WriteLine(libros.Get(numeroDeLibro).autor);
            Console.WriteLine(libros.Get(numeroDeLibro).editorial);
            Console.WriteLine(libros.Get(numeroDeLibro).paginas);
            Console.WriteLine(libros.Get(numeroDeLibro).categoria);
            Console.WriteLine(libros.Get(numeroDeLibro).anyo);
            Console.WriteLine(libros.Get(numeroDeLibro).ubicacion);
            Console.WriteLine(libros.Get(numeroDeLibro).observaciones);
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

}

