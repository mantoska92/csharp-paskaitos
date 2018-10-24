using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 10 norimu skaiciu");
            var rnd = new Random();
            var pazymiai = new List<int>();
            var kiek = 10;
            for (int i = 0; i < kiek; i++)
            {
                var pazimys = Convert.ToInt32(Console.ReadLine());
                pazymiai.Add(pazimys);
            }
            foreach (var pazimys in pazymiai)
            {
                Console.Write(pazimys + " ");
            }
            
        }
    }
}
