using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico01
{
    class TrabajoPractico01
    {
        static void Main(string[] args)
        {
            //Ejercicio #1
            Console.WriteLine("Ingresar nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Nombre y Apellido ingresado: " + nombre + " " + apellido);
            Console.ReadKey();

            //Ejercicio #2
            Console.WriteLine("Ingresar nombre");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingresar edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("No es mayor de edad");

            Console.ReadKey();

            //Ejercicio #3

            Console.WriteLine("Ingresar un numero");
            int numero = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numero; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("La suma de todos los numeros anteriores es: " + sum);
            Console.ReadKey();

            //Ejercicio #4
            Console.WriteLine("Ingresar el primer numero");
            int numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero");
            int numeroB = int.Parse(Console.ReadLine());

            int numA = numeroA;
            int numB = numeroB;
            int r = 0; //resto
            int c = 0; //cociente
            int mcd = 0;

            do
            {
                c = (numeroA / numeroB); //cociente
                r = numeroA % numeroB;   //resto

                numeroA = numeroB;
                numeroB = r;
                if (r > 0)
                {
                    mcd = r;
                }
            } while (r > 0);

            Console.WriteLine("El MCD entre " + numA + " y " + numB + " es: " + mcd);
            Console.ReadKey();

            //Ejercicio #5
            Console.WriteLine("Ingrese un numero (Si desea terminar con el circuito, presione 0)");
            int contador = 0;
            int suma = 0;
            int promedio = 0;
            int numeroIngresado = int.Parse(Console.ReadLine());

            do
            {
                contador++;
                suma = suma + numeroIngresado;
                Console.WriteLine("Ingrese un numero (Si desea terminar con el circuito, presione 0)");
                numeroIngresado = int.Parse(Console.ReadLine());
            } while (numeroIngresado != 0);

            promedio = suma / contador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.ReadKey();
        }
    }
}