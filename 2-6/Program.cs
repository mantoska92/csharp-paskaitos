using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek  pazymiu norite ivesti i sarasa?");
            var pazymiai = new List<int>();
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                var pazimys = Convert.ToInt32(Console.ReadLine());
                pazymiai.Add(pazimys);
            }
            foreach (var pazimys in pazymiai)
            {
                Console.Write(pazimys+ " ");
            }
            Console.WriteLine("didziausias:" + pazymiai.Max());
            Console.WriteLine("maziausia:" + pazymiai.Min());
            Console.WriteLine("vidurkis:" +pazymiai.Average());
            var rnd = new Random();
            var indeksas = rnd.Next(pazymiai.Count);
            Console.WriteLine(pazymiai[indeksas]);

            var desimtukai = 0;
            for (int i = 0; i < pazymiai.Count; i++)
            {
                if (pazymiai[i]==10)
                {
                    desimtukai++;
                }
            }
            Console.WriteLine("desimtuku yra gaves"+desimtukai);
            var neigiami = 0;
            for (int i = 0; i < pazymiai.Count; i++)
            {
                if (neigiami<=4)
                {
                    neigiami++;
                }
            }

            Console.WriteLine("neigiamu pazymiu yra gaves:"+neigiami);
        }
    }
}
