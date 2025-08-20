using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    // Interface que representa una figura con una única responsabilidad: calcular su área
    // Permite cumplir con el principio Open/Closed: podemos agregar nuevas figuras
    // sin modificar las clases que consumen IFigura
    public interface IFigura
    {
        float area();
    }
}
