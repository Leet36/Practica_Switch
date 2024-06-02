using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string opcion = "";
            double dato1 = 0.0;
            double dato2 = 0.0;
            double resultado = 0.0;

            do
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra sumar, para realizar una sumatoria.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra restar, para realizar una resta.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra dividir, para realizar una division.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra potencia, para realizar una operacion con exponente.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra tringulo, para calcular el area de un triangulo.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra cuadrado, para calcular el area de un cuadrado.");
                Console.WriteLine("");
                Console.WriteLine("Escriba la palabra salir, para cerrar el programa.");
                Console.WriteLine("");
                opcion = Console.ReadLine();
                Console.WriteLine("");

                switch (opcion)

                {

                    case "sumar":
                        Console.WriteLine("Ingrese el primer valor: ");
                        dato1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        dato2 = double.Parse(Console.ReadLine());
                        resultado = dato1 + dato2;
                        Console.WriteLine("");
                        Console.WriteLine("El resulado de sumarle   {0} a {1} es de {2}", dato1, dato2, resultado);
                        Console.WriteLine("");
                        break;


                    case "restar":
                        Console.WriteLine("Ingrese el primer valor: ");
                        dato1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        dato2 = double.Parse(Console.ReadLine());
                        resultado = dato1 - dato2;
                        Console.WriteLine("");
                        Console.WriteLine("El resulado de restarle a  {0} menos  {1} es de {2}", dato1, dato2, resultado);
                        Console.WriteLine("");
                        break;

                    case "dividir":
                        Console.WriteLine("Ingrese el primer valor: ");
                        dato1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        dato2 = double.Parse(Console.ReadLine());
                        resultado = dato1 / dato2;
                        Console.WriteLine("");
                        Console.WriteLine("El resulado de dividir  {0} entre {1} es de {2}", dato1, dato2, resultado);
                        Console.WriteLine("");
                        break;


                    case "triangulo":
                        Console.WriteLine("Ingrese el valor de la base: ");
                        dato1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura: ");
                        dato2 = double.Parse(Console.ReadLine());
                        resultado = (dato1 / 2) * dato2;
                        Console.WriteLine("");
                        Console.WriteLine("El area del triangulo con base de {0} y altura de {1} es de  {2}", dato1, dato2, resultado);
                        Console.WriteLine("");
                        break;

                    case "cuadrado":
                        Console.WriteLine("Ingrese el valor del lado: ");
                        dato1 = double.Parse(Console.ReadLine());
                        resultado = dato1 * dato1;
                        Console.WriteLine("");
                        Console.WriteLine("El area del cuadrado con lados  de {0}  es de {1}", dato1,  resultado);
                        Console.WriteLine("");
                        break;

                    case "potencia":
                        Console.WriteLine("Ingrese el valor base: ");
                        dato1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor del exponente: ");
                        dato2 = double.Parse(Console.ReadLine());
                        resultado=Math.Pow(dato1, dato2);
                        Console.WriteLine("");
                        Console.WriteLine("El resultado de {0}  elevado a {1} es de {2}", dato1, dato2, resultado);
                        Console.WriteLine("");
                        break;
   

                }

            } while (opcion != "salir");
        
        }
    }
}
