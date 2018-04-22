using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace EjercicioTddTest
{
    [TestClass]
    public class ParcialSimpleTest
    {
        [TestMethod]
        public void SumarDosMasDosIgualCuatro()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Sumar(2, 2);

            Assert.AreEqual(4, resultado);
            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");

        }

        [TestMethod]
        public void SumarCaracteres()
        {
            CalculadoraSimple calcu = new CalculadoraSimple();
            int resultado = calcu.Sumar("1", "2");

            Assert.AreEqual(3, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }

        [TestMethod]
        public void SumarCaracteresVacio()
        {
            CalculadoraSimple calc = new CalculadoraSimple();
            int resultado = calc.SumarV(" ", "2");
            

                Assert.AreEqual(2, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }
        [TestMethod]
        public void RestarTresMenosUno()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Restar(3, 1);

            Assert.AreEqual(2, resultado);

            if ((resultado) >= 0)

                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");

        }
        [TestMethod]
        public void MultiplicarDosPorDos()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Mult(2, 2);

            Assert.AreEqual(4, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");

        }
        [TestMethod]
        public void MultiplicarTresPorCero()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Multiplicar(0, 2);

            Assert.AreEqual(0, resultado);
            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");

        }
        [TestMethod]
        public void DividirSeisEnDos()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Dividir(6, 2);
            
            Assert.AreEqual(3, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }
        [TestMethod]
        public void RedondeoDeDivisiones()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            double resultado = cal.Redondeo(7, 4);
            double a = resultado;
            

            Assert.AreEqual(1,2, resultado);

            if(a < 0.5)
                Console.WriteLine("Su resultado es elevado hacia abajo :" + Math.Round(a));
            else if (a >= 0.5)
                Console.WriteLine("Su Resultado es elevado hacia arriba :" + Math.Ceiling(a));
        }
        [TestMethod]
        public void ResiduoDeDivisiones()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.Residuo(5, 4);

            Assert.AreEqual(1, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }
        [TestMethod]
        public void Potencias()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            double resultado = cal.Elevar(2, 2);

            Assert.AreEqual(4, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : "+ resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }
        [TestMethod]
        public void RaizCuadrada()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            double resultado = cal.Raiz(4);

            Assert.AreEqual(2, resultado);

            if ((resultado) >= 0)
                Console.WriteLine("El Resultado es : " + resultado);
            else
                Console.WriteLine("Esta Incorrecto");
        }
    }
}
