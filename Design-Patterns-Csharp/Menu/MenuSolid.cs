using System;
using Design_Patterns_Csharp.SOLID.Simple;

namespace Design_Patterns_Csharp.Menu
{
    public static class MenuSolid
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Principios SOLID ===");
                Console.WriteLine("1. Single Responsibility Principle");
                Console.WriteLine("2. Open/Closed Principle");
                Console.WriteLine("0. Volver");
                Console.Write("Seleccione una opción: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DemoSRP.Run();
                        break;
                    case "2":
                        //DemoOpenClose.Run();
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
}
