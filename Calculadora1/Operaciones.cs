using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    internal class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {

              return false;
            }
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b) 
        {
            return a - b;
            
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }




    }
}
