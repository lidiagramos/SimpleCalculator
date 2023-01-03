using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  class Program
    {
        static void Main(string[] args)
        {

            Operadorescs C = new Operadorescs();

            string menu;
            

            Console.WriteLine("Digite + para adição;");
            Console.WriteLine("Digite - para subtração;");
            Console.WriteLine("Digite * para multiplicação;");
            Console.WriteLine("Digite / para divisão;");
            Console.WriteLine("Ou digite Q para fechar o programa.");
            menu = Console.ReadLine();


            if(menu == "+")
            {
                Console.WriteLine("Digite os números para realizar a soma");
                C.mais(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
            }
            else if(menu == "-")
            {
                Console.WriteLine("Digite os números para realizar a subtração");
                C.menos(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            }
            else if (menu == "*")
            {
                Console.WriteLine("Digite os números para realizar a multiplicação");
                C.vezes(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            }
            else if (menu == "/")
            {
                Console.WriteLine("Digite os numeros para realizar a divisão");
                C.dividir(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            }
            else if (menu == "Q")
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
