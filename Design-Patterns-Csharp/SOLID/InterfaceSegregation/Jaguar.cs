using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    public class Jaguar : IFelino
    {
        
    public void rugir()
        {
            Console.WriteLine("El jaguar ruge!");
        }
    public void cazar()
        {
            Console.WriteLine("El jaguar caza!");
        }        
    public void maullar()
        {
            // ⚠️ Jaguar no maúlla: estamos forzando una implementación sin sentido
            Console.WriteLine("Error, El jaguar no maulla");
        }
    }
}
