using Design_Patterns_Csharp.SOLID.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Csharp.SOLID.Simple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // --- Ejemplo sin aplicar SRP ---
            var rectangulo = new Rectangulo(10, 20);
            rectangulo.Imprimir();

            /*
             * En este ejemplo, la clase Rectangulo se encarga tanto de representar
             * los datos geométricos como de imprimir su información.
             * Esto rompe el Principio de Responsabilidad Única (SRP),
             * ya que tiene más de una responsabilidad.
             */

            // --- Ejemplo aplicando SRP ---
            var rectanguloSRP = new RectanguloSRP(20, 30);
            var presentacion = new Presentacion();
            presentacion.Imprimir(rectanguloSRP);

            /*
             * Aquí dividimos las responsabilidades:
             * - RectanguloSRP se encarga solo del modelo de datos y cálculos.
             * - Presentacion se encarga de mostrar la información por pantalla.
             * Cada clase tiene una sola responsabilidad, cumpliendo con el SRP.
             */
        }
    }
}
