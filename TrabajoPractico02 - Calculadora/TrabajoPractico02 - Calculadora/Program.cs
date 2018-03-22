using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico02___Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculos = "10+20/3*10+20/60";
            string valor1 = "";
            string valor2 = "";
            int resultado = 0;
            int contadorOperador = 0;
            string operador = "";

            foreach (var calculo in calculos)
            {
                switch (calculo)
                {
                    case '+':
                        if (contadorOperador == 1)
                        {
                            if (operador == "+")
                                resultado = resultado + int.Parse(valor2);
                            else if (operador == "-")
                                resultado = resultado - int.Parse(valor2);
                            else if (operador == "/")
                                resultado = resultado / int.Parse(valor2);
                            else
                                resultado = resultado * int.Parse(valor2);
                        }
                        else
                        {
                            resultado = int.Parse(valor1);
                        }

                        contadorOperador = 1;
                        operador = "+";
                        valor2 = valor1;
                        valor1 = "";
                        break;
                    case '-':
                        if (contadorOperador == 1)
                        {
                            if (operador == "+")
                                resultado = resultado + int.Parse(valor2);
                            else if (operador == "-")
                                resultado = resultado - int.Parse(valor2);
                            else if (operador == "/")
                                resultado = resultado / int.Parse(valor2);
                            else
                                resultado = resultado * int.Parse(valor2);
                        }
                        else
                        {
                            resultado = int.Parse(valor1);
                        }
                        contadorOperador = 1;
                        operador = "-";
                        valor2 = valor1;
                        valor1 = "";
                        break;
                    case '/':
                        if (contadorOperador == 1)
                        {
                            if (operador == "+")
                                resultado = resultado + int.Parse(valor2);
                            else if (operador == "-")
                                resultado = resultado - int.Parse(valor2);
                            else if (operador == "/")
                                resultado = resultado / int.Parse(valor2);
                            else
                                resultado = resultado * int.Parse(valor2);
                        }
                        else
                        {
                            resultado = int.Parse(valor1);
                        }
                        contadorOperador = 1;
                        operador = "/";
                        valor2 = valor1;
                        valor1 = "";
                        break;
                    case '*':
                        if (contadorOperador == 1)
                        {
                            if (operador == "+")
                                resultado = resultado + int.Parse(valor2);
                            else if (operador == "-")
                                resultado = resultado - int.Parse(valor2);
                            else if (operador == "/")
                                resultado = resultado / int.Parse(valor2);
                            else
                                resultado = resultado * int.Parse(valor2);
                        }
                        else
                        {
                            resultado = int.Parse(valor1);
                        }
                        contadorOperador = 1;
                        operador = "*";
                        valor2 = valor1;
                        valor1 = "";
                        break;
                    default:
                         valor1 += calculo;
                         valor2 = valor1;
                        break;
                }
            }

            if (operador == "+")
                resultado = resultado + int.Parse(valor2);
            else if (operador == "-")
                resultado = resultado - int.Parse(valor2);
            else if (operador == "/")
                resultado = resultado / int.Parse(valor2);
            else
                resultado = resultado * int.Parse(valor2);

            Console.WriteLine("El resultado de la operación matemática ("+calculos+") es: " + resultado);
            Console.ReadKey();
        }
    }
}
