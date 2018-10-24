using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace su_argumetais_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodis = "pavadinimas";
            p.pavadinimas("pomidoras");
            p.pavadinimas("avis");
            p.pavadinimas("agurkas");
            p.pavadinimas("fuksas");

        }

        public void pavadinimas(string zod)
        {
            Console.WriteLine("--" + zod + "-- ");
        }





    }
}
