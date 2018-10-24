using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i <skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i] + ", ");
            }Console.WriteLine();
        }
        
    }
}
