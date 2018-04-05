using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico03___Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija figura a calcular: [A] Triangulo, [B] Cuadrado, [C] Circulo");
            string figura = Console.ReadLine();
            if (figura == "A")
            {
                Triangulo triangulo = new Triangulo();
                Console.WriteLine("Ingrese la base");
                double base_figura = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura");
                double altura_figura = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese primer lado");
                double ladoA = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo lado");
                double ladoB = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer lado");
                double ladoC = Double.Parse(Console.ReadLine());

                triangulo.Base_figura = base_figura;
                triangulo.Altura_figura = altura_figura;
                triangulo.LadoA = ladoA;
                triangulo.LadoB = ladoB;
                triangulo.LadoC = ladoC;

                double area = triangulo.calcularArea();
                double perimetro = triangulo.calcularPerimetro();

                Console.WriteLine("Figura ingresada: " + figura + "\n" +
                                  "Area: " + area + "\n" +
                                  "Perimetro: " + perimetro + "\n");

                Console.ReadKey();
            }
            if (figura == "B")
            {
                Cuadrado cuadrado = new Cuadrado();
                Console.WriteLine("Ingrese la base");
                double base_figura = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura");
                double altura_figura = Double.Parse(Console.ReadLine());

                cuadrado.Altura_figura = altura_figura;
                cuadrado.Base_figura = base_figura;

                double area = cuadrado.calcularArea();
                double perimetro = cuadrado.calcularPerimetro();

                Console.WriteLine("Figura ingresada: " + figura + "\n" +
                                  "Area: " + area + "\n" +
                                  "Perimetro: " + perimetro + "\n");

                Console.ReadKey();
            }
            if (figura == "A")
            {
                Circulo circulo = new Circulo();
                Console.WriteLine("Ingrese el radio");
                double radio_figura = Double.Parse(Console.ReadLine());

                circulo.Radio = radio_figura;
                double area = circulo.calcularArea();
                double perimetro = circulo.calcularPerimetro();

                Console.WriteLine("Figura ingresada: " + figura + "\n" +
                                  "Area: " + area + "\n" +
                                  "Perimetro: " + perimetro + "\n");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor ingreasdo no coincide con las opciones. Morite por bolud#");
            }
        }
    }
}
