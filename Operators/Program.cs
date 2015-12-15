using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sintaxe
            int a = 10;
            int b = 2;

            //Aritmeticos

            //Add
            int add = a + b;

            //Sub
            int subt = a - b;

            //Mult
            int mult = a * b;

            //Divis
            int divis = a / b;

            //Rest
            int rest = 5 / 2;

            //Primary

            //Incremento x++
            //Decremento x--

            //Comparativos

            if (a > b)
            {
                //Console.WriteLine("a > b");
            }

            if (b < a)
            {
                //Console.WriteLine("b < a");
            }

            // => - Lambda
            if (a >= b)
            {
                //Console.WriteLine("b < a");
            }

            if (b <= a)
            {
                //Console.WriteLine("b < a");
            }

            //Equals
            if (a == b)
            {
                //Console.WriteLine("b < a");
            }

            //Not
            if (a != b)
            {
                //Console.WriteLine("b < a");
            }

            //Logicos
            //XOR - logico exclusivo - Um ou outro
            if (true ^ false)
            {
                //Console.WriteLine("True");
            }

            //Condicionais
            //AND
            if (true && true)
            {
                //Console.WriteLine("True");
            }

            //OR --> if(a < b || b > c)
            if (false || true)
            {
                //Console.WriteLine("True");
            }
            #endregion

            Console.WriteLine("Valor 1 ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2 ");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Soma: " + Convert.ToString(v1 + v2));
            Console.WriteLine("Subtração: " + Convert.ToString(v1 - v2));
            Console.WriteLine("Multiplicação: " + Convert.ToString(v1 * v2));
            Console.WriteLine("Divisão: " + Convert.ToString(v1 / v2));

            if (v1 > 0 && v2 > 0)
                Console.WriteLine("Os valores v1 e v2 Maiores que Zero");

            if (v1 + v2 <= 0 || v1 - v2 <= 0 || v1 * v2 <= 0 || v1 / v2 <= 0)
                Console.WriteLine("Uma ou mais operações possuem valor Menor ou Igual a Zero");

            Console.ReadKey();
        }
    }
}
