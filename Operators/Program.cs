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
                Console.WriteLine("a > b");

            if (b < a)
                Console.WriteLine("b < a");

            // => - Lambda
            if (a >= b) 
                Console.WriteLine("b < a");

            if (b <= a)
                Console.WriteLine("b < a");

            //Equals
            if (a == b)
                Console.WriteLine("b < a");

            //Not
            if (a != b)
                Console.WriteLine("b < a");

            //Logicos
            //XOR - logico exclusivo - Um ou outro
            if(true ^ false)
                Console.WriteLine("True");

            //Condicionais
            //AND
            if (true && true)
                Console.WriteLine("True");

            //OR --> if(a < b || b > c)
            if(false || true)
                Console.WriteLine("True");

        }
    }
}
