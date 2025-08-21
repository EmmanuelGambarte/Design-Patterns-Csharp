using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    // ✅ Interface para felinos salvajes: solo agrega rugir
    public interface IFelinoSalvajeIS : IFelinoIS
    {
        void rugir();
    }
}
