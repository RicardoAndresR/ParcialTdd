using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraSimple
    {

        public int Sumar(int a, int b) {
            return  a + b;
        }
        public int Sumar(string d, string c)
        {
           
           
            return  Convert.ToInt16(d) + Convert.ToInt16(c);
        }

        public int SumarV(string e, string f) {
            int e1 = e.Equals(" ") ? 0 : Convert.ToInt16(e);
            int f1 = f.Equals(" ") ? 0 : Convert.ToInt16(f);
            return e1 + f1;
            
        }
        public int Restar(int a, int b) {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            
            return a /  b;
        }
        public double Redondeo(double a, double b)
        {
            
            return  a /  b;
            


        }
       
        public int Residuo(int a, int b)
        {

            return a % b;
        }
        public double Elevar(double a, double b)
        {

            return Math.Pow(a, b);
        }
        public double Raiz(double a)
        {

            return Math.Sqrt(a);
        }
    }
}
