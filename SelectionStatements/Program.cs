using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if

            //if
            int a = 10;

            if(a == 5)
                Console.WriteLine("a = 5");
            else
                Console.WriteLine("a <> 5");

            //Sintaxe Alternativa
            int b = (a < 10) ? 5 : 0;

            /*
            if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("a <> 5");
            }
            */

            bool ok = true;
            if(ok)
                Console.WriteLine("OK");

            #endregion

            #region switch
            if (a == 5)
            {
                if(true)
                {
                    Console.WriteLine("a = 5");
                }
                
            }
            else if (a == 10)
            {
                Console.WriteLine("a == 10");
            }
            else if (a == 8)
            {
                Console.WriteLine("a == 8");
            }
            else
            {
                Console.WriteLine("a == "+ a.ToString());
            }

            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Console.WriteLine("C == 0");
                    break;
                case 5:
                    Console.WriteLine("C == 5");
                    break;
                case 10:
                    Console.WriteLine("C == 10");
                    break;
                default:
                    Console.WriteLine("C == " + c.ToString());
                    break;
            }

            #endregion

            Console.ReadKey();
        }
    }
}
