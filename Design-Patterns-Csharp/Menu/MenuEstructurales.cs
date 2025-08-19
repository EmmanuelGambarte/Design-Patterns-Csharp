using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.Menu
{
    public static class MenuEstructurales
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Patrones Estructurales ===");
                Console.WriteLine("1. Adapter");
                Console.WriteLine("2. Composite");
                Console.WriteLine("3. Decorator");
                Console.WriteLine("4. Facade");
                Console.WriteLine("0. Volver");
                Console.Write("Seleccione una opción: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //DemoAdapter.Run();
                        break;
                    case "2":
                        //DemoComposite.Run();
                        break;
                    case "3":
                        //DemoDecorator.Run();
                        break;
                    case "4":
                        //DemoFacade.Run();
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
