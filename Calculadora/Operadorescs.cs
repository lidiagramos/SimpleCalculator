using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{ 
    class Operadorescs
    {

        public double num1;
        public double num2;
        public double result;

        public void mais(double a, double b)
        { 
            num1 = a;
            num2 = b;
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void menos(double a, double b)
        {
            num1 = a;
            num2 = b;
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadKey();

        }
        public void vezes(double a, double b)
        {
            
            num1 = a;
            num2 = b;
            result = num1 / num2;
            Console.WriteLine(result);
            Console.ReadKey();

        }
        public void dividir(double a, double b)
        {          
            num1 = a;
            num2 = b;
            result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadKey();

        }

    }
}
