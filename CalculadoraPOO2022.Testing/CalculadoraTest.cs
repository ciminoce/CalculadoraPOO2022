using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraPOO2022.Entidades;

namespace CalculadoraPOO2022.Testing
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Test_Calcular_Suma()
        {
            //Arrange
            int numero1 = 2;
            int numero2 = 3;
            //Act
            int resultado = Calculadora.Sumar(numero1, numero2);
            //Assert
            Assert.AreEqual(5,resultado);
        }
        [TestMethod]
        public void Test_Calcular_Resta()
        {
            //Arrange
            int numero1 = 2;
            int numero2 = 3;
            //Act
            int resultado = Calculadora.Restar(numero1, numero2);
            //Assert
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Test_Calcular_Producto()
        {
            //Arrange
            int numero1 = 2;
            int numero2 = 3;
            //Act
            int resultado = Calculadora.Producto(numero1, numero2);
            //Assert
            Assert.AreEqual(6, resultado);
        }
        [TestMethod]
        public void Test_Calcular_Division()
        {
            //Arrange
            int numero1 = 6;
            int numero2 = 3;
            //Act
            double resultado = Calculadora.Division(numero1, numero2);
            //Assert
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Calcular_Division_ThrowsException()
        {
            //Arrange
            int numero1 = 6;
            int numero2 = 0;
            //Act
            double resultado = Calculadora.Division(numero1, numero2);
           
        }

        [TestMethod]
        
        public void Test_Calcular_Division_ThrowsExceptionToo()
        {
            //Arrange
            int numero1 = 6;
            int numero2 = 0;
            //Act
            //double resultado = Calculadora.Division(numero1, numero2);
            //Assert
            Assert.ThrowsException<DivideByZeroException>(() => Calculadora.Division(numero1, numero2));
        }
        [TestMethod]

        public void Test_Calcular_Division_ThrowsExceptionTryCatch()
        {
            //Arrange
            int numero1 = 6;
            int numero2 = 0;
            //Act
            try
            {
                double resultado = Calculadora.Division(numero1, numero2);

            }
            catch (DivideByZeroException)
            {

                return;
            }
            //Assert
            Assert.Fail("No se pudo realizar la división por cero");
        }

    }
}
