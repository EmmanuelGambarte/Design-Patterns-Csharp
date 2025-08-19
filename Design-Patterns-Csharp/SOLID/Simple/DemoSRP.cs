using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Simple
{
    public static class DemoSRP
    {
        public static void Run()
        {
            var rectangulo = new Rectangulo(10, 20);
            rectangulo.Imprimir();

            var rectanguloSRP = new RectanguloSRP(20, 30);
            var presentacion = new Presentacion();
            presentacion.Imprimir(rectanguloSRP);
        }
    }
}
