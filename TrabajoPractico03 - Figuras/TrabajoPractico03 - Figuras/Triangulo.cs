using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico03___Figuras
{
    class Triangulo : FiguraGeometrica
    {
        private double altura_figura;
        private double base_figura;
        private double ladoA;
        private double ladoB;
        private double ladoC;
        private double area;
        private double perimetro;

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double LadoC { get => ladoC; set => ladoC = value; }
        public double Base_figura { get => base_figura; set => base_figura = value; }
        public double Altura_figura { get => altura_figura; set => altura_figura = value; }

        public override double calcularArea()
        {
            area = (Base_figura * Altura_figura) / 2;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = LadoA + LadoB + LadoC;
            return perimetro;
        }
    }
}
