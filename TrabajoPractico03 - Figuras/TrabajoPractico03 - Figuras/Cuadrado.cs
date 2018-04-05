using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico03___Figuras
{
    class Cuadrado : FiguraGeometrica
    {
        private double area;
        private double perimetro;
        private double base_figura;
        private double altura_figura;

        public double Base_figura { get => base_figura; set => base_figura = value; }
        public double Altura_figura { get => altura_figura; set => altura_figura = value; }

        public override double calcularArea()
        {
            area = base_figura * altura_figura;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = (base_figura * 2) + (altura_figura * 2);
            return perimetro;
        }
    }
}
