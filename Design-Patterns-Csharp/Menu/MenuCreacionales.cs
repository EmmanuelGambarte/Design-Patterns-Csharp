using System;

namespace Design_Patterns_Csharp.Menu
{
    public static class MenuCreacionales
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Patrones Creacionales ===");
                Console.WriteLine("1. Simple Factory");
                // Agregá más patrones
                Console.WriteLine("0. Volver");
                Console.Write("Seleccione una opción: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //DemoSimpleFactory.Run();
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
