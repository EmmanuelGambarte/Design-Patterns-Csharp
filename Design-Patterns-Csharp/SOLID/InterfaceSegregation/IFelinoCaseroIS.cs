using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.InterfaceSegregation
{
    // ✅ Interface para felinos domésticos: solo agrega maullar
    public interface IFelinoCaseroIS : IFelinoIS
    {
        void maullar();
    }
}
