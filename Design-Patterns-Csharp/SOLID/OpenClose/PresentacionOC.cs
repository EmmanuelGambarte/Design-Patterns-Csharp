using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    // Esta clase cumple con el principio Open/Closed
    // porque no necesita cambiar si agregamos nuevas figuras.
    // Solo necesita que las figuras implementen la interfaz IFigura.
    public class PresentacionOC
    {
        public void area(IFigura figura)
        {
            Console.WriteLine(figura.area());
        }
    }
}
