using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico03___Figuras
{
    class Circulo : FiguraGeometrica
    {
        private double radio;
        private double area;
        private double perimetro;

        public double Radio { get => radio; set => radio = value; }

        public override double calcularArea()
        {
            area = Math.PI * Math.Pow(Radio, 2);
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = 2 * Math.PI * Radio;
            return perimetro;
        }
    }
}
