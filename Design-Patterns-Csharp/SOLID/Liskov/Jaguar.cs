using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Liskov
{
    public class Jaguar : IFelinoPSL
    {
        
    public void emitirSonido()
        {
            Console.WriteLine("El jaguar ruge!");
        }

        
    public void cazar()
        {
            Console.WriteLine("El jaguar caza!");
        }
    }
}
