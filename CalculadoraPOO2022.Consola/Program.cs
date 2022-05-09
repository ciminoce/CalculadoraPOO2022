using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraPOO2022.Entidades;

namespace CalculadoraPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Calculadora.Sumar(4, 5);
            var resultado2 = Calculadora.Sumar(4.5, 7.2);
            Console.WriteLine($"La suma es {resultado}");
            Console.WriteLine($"La suma es {resultado2}");

            Console.ReadLine();
        }
    }
}
