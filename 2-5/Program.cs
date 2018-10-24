using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek vardu noresite ivesti?");
            var vardai = new List<string>();
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                var vardas = Console.ReadLine();
                vardai.Add(vardas);

            }
            foreach (var vardas in vardai)
            {
                Console.Write(vardas + " ");
            }
            Console.WriteLine();
        }
    }
}
