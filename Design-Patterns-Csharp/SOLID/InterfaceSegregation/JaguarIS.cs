using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    public class JaguarIS : IFelinoSalvajeIS
    {        
    public void rugir()
        {
            Console.WriteLine("El jaguar ruge!");
        }        
    public void cazar()
        {
            Console.WriteLine("El jaguar caza!");
        }
    }
}
