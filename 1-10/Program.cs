using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5 };
            var skaiciai2 = new[] { 6, 7, 8, 9, 10 };
            var suma = skaiciai.Sum();
            var suma2 = skaiciai2.Sum();
            var vidurkis = skaiciai.Average();
            var vidurkis2 = skaiciai2.Average();
            Console.WriteLine("suma:"+suma);
            Console.WriteLine( "vidurkis:"+vidurkis);
            Console.WriteLine("suma:" + suma2  );
            Console.WriteLine("vidurkis:"+vidurkis2);
            if (vidurkis>vidurkis2)
            {
                Console.WriteLine("pirmo masyvo vidurkis didesnis");
            }
            else if (vidurkis2>vidurkis)
            {
                Console.WriteLine("antro masyvo vidurkis didesnis");
            }
            else
            {
                Console.WriteLine("masyvai lygus");
            }
        }   
        
    }       
}
