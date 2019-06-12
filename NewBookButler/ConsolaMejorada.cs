using System;

class ConsolaMejorada
{
    public static void Escribir(int x, int y, string texto, string color)
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof
                                    (ConsoleColor), color, true);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
        Console.ResetColor();
    }

    public static void PedirTexto(int x, int y, int longitud)
    {
        string hueco = new string('-', longitud); 
        Console.SetCursorPosition(x, y);
        Console.WriteLine(hueco);
    }

    public static void DibujarVentana(int x, int y, int ancho, int alto,
                                        string color)
    {

        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof
                                    (ConsoleColor), color, true);
        Console.SetCursorPosition(x, y);

        for (int i = 0; i < ancho; i++)
        {
            Console.WriteLine(" ");
        }
        Console.WriteLine();

        for (int i = 0; i < alto - 2; i++)
        {
            Console.Write(" ");
            for (int j = 0; j < ancho - 2; j++)
            {
                Console.Write(" ");
            }
            Console.Write(" ");
            Console.WriteLine();
        }

        for (int i = 0; i < ancho; i++)
        {
            Console.Write(" ");
        }
    }


    public static void DibujarVentanaTamanyoFijo(string texto, string
                                        colorTexto, string colorFondo)
    {

        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof
                                    (ConsoleColor), colorFondo, true);

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof
                                    (ConsoleColor), colorTexto, true);

        for (int i = 0; i < 40; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();

        for (int i = 0; i < (8 - 2); i++)
        {
            Console.Write(" ");
            for (int j = 0; j < (40 - 2); j++)
            {
                Console.Write(" ");
            }
            Console.Write(" ");
            Console.WriteLine();
        }
        Console.Write(texto);
        for (int i = 0; i < 40; i++)
        {
            Console.Write(" ");
        }
    }

    public static void EscribirCentrado(int fila, string frase,
                        string color)
    {

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof
                                    (ConsoleColor), color, true);

        string espacios = new string(' ', fila);
        Console.WriteLine(espacios + frase);
    }

    public static void PedirEnteroEntreDosValores(int num1, int num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine("Números iguales");
        }

        if (num1 != num2)
        {

            Console.WriteLine("Dime número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 <= num && num <= num2)
                {
                    Console.WriteLine("Número correcto");
                }
                else
                {
                    Console.WriteLine("Número incorrecto");
                }
            }
            else if (num1 > num2)
            {
                if (num2 <= num && num <= num1)
                {
                    Console.WriteLine("Número correcto");
                }
                else
                {
                    Console.WriteLine("Número incorrecto");
                }
            }
        }
    }
}

