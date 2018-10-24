using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite norima duomenu kieki");
            Console.WriteLine("keliu dienu temperaturas norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var temperaturos = new int[kiek];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                Console.Write ("iveskite {0} dienos temperatura:",1+i);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var temperatura in temperaturos)
            {
                Console.Write(temperatura + ",");
            }
            var suma = 0;
            foreach (var skaiciai in temperaturos)
            {
                suma += skaiciai;
            }
            var vidurkis = suma / temperaturos.Length;
            Console.WriteLine("\nsuvestu temperaturu vidurkis:"+vidurkis);


            var min = temperaturos [0];
            foreach (var maziausias in temperaturos)
            {
                if (maziausias<min)
                {
                    min = maziausias;
                }
            }
            Console.WriteLine("zemiausia temperatura buvo:"+min);

            var max = temperaturos [0];
            var auksciausiaIndeksas = 0;

            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] > max)
                {
                    max = temperaturos[i];
                    auksciausiaIndeksas = i;
                }
            }

            //foreach (var didziausia in temperaturos) // 
            //{
            //    if (didziausia > max)
            //    {
            //        max = didziausia;

            //    }
            //}


                    Console.WriteLine( "diena buvo karsciausia ir sieke:" +max);
            Console.WriteLine("diena " + (auksciausiaIndeksas+1));
            var skirtumas = max-min;
            Console.WriteLine("maziausios ir didziausios temperaturos skirtumas:"+skirtumas);



            
        }
    }
}
