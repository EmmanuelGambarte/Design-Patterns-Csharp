using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    // ❌ Interface muy general: obliga a implementar métodos que no siempre tienen sentido
    public interface IFelino
    {
        void rugir();

        void maullar();

        void cazar();
    }
}
