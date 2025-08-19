using System;
using Design_Patterns_Csharp.Menu;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Principios SOLID");
            Console.WriteLine("2. Patrones Creacionales");
            Console.WriteLine("3. Patrones de Comportamiento");
            Console.WriteLine("4. Patrones Estructurales");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MenuSolid.Mostrar();
                    break;
                case "2":
                    MenuCreacionales.Mostrar();
                    break;
                case "3":
                    MenuComportamiento.Mostrar();
                    break;
                case "4":
                    MenuEstructurales.Mostrar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para intentar de nuevo...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
