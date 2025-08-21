using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    public class DemoIS
    {
        public static void Run()
        {
            Console.WriteLine("Sin aplicar la Segregación de Interfaces:");
            Jaguar jaguar = new Jaguar();
            jaguar.maullar(); // ⚠️ Comportamiento innecesario

            Console.WriteLine("/////////////----------///////////");

            Console.WriteLine("Aplicando la Segregación de Interfaces:");
            JaguarIS jaguarIS = new JaguarIS();
            jaguarIS.cazar(); // ✅ Solo los métodos válidos
        }
    }
}
