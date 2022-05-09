using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO2022.Entidades
{
    public static class Calculadora
    {
        public static int Sumar(int numero1, int numero2) =>numero1+numero2;
        public static double Sumar(double numero1, double numero2) => numero1 + numero2;
        public static int Restar(int numero1, int numero2) => numero1 - numero2;
        public static int Producto(int numero1, int numero2) =>numero1*numero2;

        public static double Division(int numero1, int numero2)
        {
            if (numero2==0)
            {
                throw new DivideByZeroException();
            }

            return numero1/numero2;
        }

    }
}
