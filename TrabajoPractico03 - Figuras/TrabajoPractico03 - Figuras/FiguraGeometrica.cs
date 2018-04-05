using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico03___Figuras
{
    abstract class FiguraGeometrica
    {
        public abstract double calcularPerimetro();
        public abstract double calcularArea();

        public void imprimir()
        {
            Console.WriteLine("Area: " + calcularArea());
            Console.WriteLine("Perimetro: " + calcularPerimetro());
        }
    }
}
