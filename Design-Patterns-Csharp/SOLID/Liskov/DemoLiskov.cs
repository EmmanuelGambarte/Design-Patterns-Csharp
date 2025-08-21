using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Liskov
{
    public class DemoLiskov
    {
         public static void Run()
        {
            Console.WriteLine("===== Principio de Sustitución de Liskov (LSP) =====\n");

            // ✅ Ejemplo válido de herencia: Jaguar
            Jaguar jaguar = new Jaguar();
            jaguar.emitirSonido(); // El jaguar ruge
            jaguar.cazar();        // El jaguar caza

            Console.WriteLine();

            // ❌ Ejemplo que viola LSP
            Console.WriteLine("Violación de LSP:");
            Jaguar otroJaguar = new GatoDomestico();
            otroJaguar.emitirSonido(); // ⚠️ Comportamiento inesperado
            otroJaguar.cazar();

            Console.WriteLine();

            // ✅ Ejemplo correcto usando una interfaz común
            Console.WriteLine("Ejemplo correcto con interfaz:");
            IFelinoPSL felino1 = new Jaguar();
            felino1.emitirSonido(); // OK
            felino1.cazar();

            IFelinoPSL felino2 = new GatoDomesticoPSL();
            felino2.emitirSonido(); // OK: maúlla
            felino2.cazar();

            Console.WriteLine("\n==================================================\n");
        }
    }
}
