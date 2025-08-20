using Design_Patterns_Csharp.SOLID.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    // Esta clase viola el principio Open/Closed
    // porque cada vez que agregamos una nueva figura,
    // debemos modificar esta clase y agregar un nuevo método.
    public class Presentacion
    {
        public void area(Rectangulo rectangulo)
        {
            Console.WriteLine(rectangulo.getBasee() * rectangulo.getAltura());
        }

        public void area(Triangulo triangulo)
        {
            Console.WriteLine((triangulo.getBase() * triangulo.getAltura()) / 2);
        }
    }
}
