using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Simple
{
    // Clase que sigue el Principio de Responsabilidad Única (SRP)
    public class RectanguloSRP
    {
        private float _base;
        private float _altura;

        public RectanguloSRP(float @base, float altura)
        {
            _base = @base;
            _altura = altura;
        }

        public float Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public float Area()
        {
            return _base * _altura;
        }

        public override string ToString()
        {
            return $"Base: {_base} | Altura: {_altura}";
        }
    }
}
