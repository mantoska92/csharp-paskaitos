using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 4, 5, 8, 9, 7, 1, 3 };

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("indekse {0} yra skaicius {1}", i, skaiciai[i]);
            }
        }
    }
}
