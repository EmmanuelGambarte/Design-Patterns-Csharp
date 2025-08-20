using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.OpenClose
{
    public class Triangulo
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

        public Triangulo(float basee, float altura)
        {
            this.setBasee(basee);
            this.setAltura(altura);
        }

        public float area()
        {
            return (getBasee() * getAltura()) / 2;
        }
    }
}
