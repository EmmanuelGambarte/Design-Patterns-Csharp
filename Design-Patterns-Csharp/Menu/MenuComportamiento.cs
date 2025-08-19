using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.Menu
{
    public static class MenuComportamiento
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Patrones de Comportamiento ===");
                Console.WriteLine("1. Command");
                Console.WriteLine("2. Observer");
                Console.WriteLine("3. Strategy");
                Console.WriteLine("0. Volver");
                Console.Write("Seleccione una opción: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //DemoCommand.Run();
                        break;
                    case "2":
                        //DemoObserver.Run();
                        break;
                    case "3":
                        //DemoStrategy.Run();
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
