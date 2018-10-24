using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai1 = new[] { 7, 8, 9, 4, 5, 6 };
            var skaiciai2 = new[] { 1, 2, 3, 10, 14, 15 };
            var suma = 0;
            foreach (var sk in skaiciai1)
            {
                suma += sk;
            }
            Console.WriteLine("skaiciu1 suma" + suma);
            var suma2 = 0;
            foreach (var sk in skaiciai2)

            {
                suma2 += sk;
            }
            Console.WriteLine("skaiciu 2suma" + suma2);
            if (suma > suma2)

            {
                Console.WriteLine("pirmas didesnis");
            }
            else if (suma2 > suma)
            {
                Console.WriteLine("antras didesnis");
            }
            else;
        }
    }
}
