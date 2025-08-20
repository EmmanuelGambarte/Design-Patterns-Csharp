using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    // Esta clase viola el principio Open/Closed (OCP)
    // porque la lógica de cálculo de área es específica
    // y no está unificada por una interfaz.
    public class Rectangulo
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

        public Rectangulo(float basee, float altura)
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
