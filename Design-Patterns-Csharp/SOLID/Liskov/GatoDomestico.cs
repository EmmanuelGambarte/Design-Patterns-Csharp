using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Liskov
{
    public class GatoDomestico : Jaguar
    {
        public void rugir()
        {
            // ❌ comportamiento inesperado o lanzamos excepción
            Console.WriteLine("Error, El gato doméstico no puede rugir");
        }

        
    public void cazar()
        {
            Console.WriteLine("El gato doméstico juega con la comida en lugar de cazar");
        }
    }
}
