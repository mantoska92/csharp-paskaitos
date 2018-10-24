using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace su_grazinimu_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();
            var skaiciai = p.GeneruotiSkaicius(rand);
            p.isvvedimas(skaiciai);
        }

        public List<int>GeneruotiSkaicius(Random rand)
        {
            var skaiciai = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                skaiciai.Add(rand.Next(100));
            }

            return skaiciai;
        }
        public void isvvedimas(List<int> skaiciai)
        {
            foreach (var i in skaiciai)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine();
        }
    }
}
