using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5, 6 };
            var suma = 0;
            foreach (var sk in skaiciai)
            {
                suma += sk;
            }
            var vidurkis = (double)suma / skaiciai.Length;
            Console.WriteLine("suma:"+ suma);
            Console.WriteLine("vidurkis:" + vidurkis);
        }
    }
}
