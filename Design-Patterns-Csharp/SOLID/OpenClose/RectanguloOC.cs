using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    // Aplica el principio Open/Closed al implementar la interfaz IFigura
    // Podemos agregar nuevas figuras sin tocar el código existente.
    internal class RectanguloOC : IFigura
    {
        private float basee;
    private float altura;

        public float getBasee()
        {
            return basee;
        }

        public void setBasee(float basee)
        {
            this.basee = basee;
        }

        public float getAltura()
        {
            return altura;
        }

        public void setAltura(float altura)
        {
            this.altura = altura;
        }

        public RectanguloOC(float basee, float altura)
        {
            this.setBasee(basee);
            this.setAltura(altura);
        }

        public float area()
        {
            return getBasee() * getAltura();
        }
    }
}
