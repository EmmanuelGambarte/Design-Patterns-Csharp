using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Liskov
{
    public class GatoDomesticoPSL : IFelinoPSL
    {
       
    public void emitirSonido()
        {
            Console.WriteLine("El gato maúlla!");
        }

        
    public void cazar()
        {
            Console.WriteLine("El gato juega con la presa!");
        }
    }
}

