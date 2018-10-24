using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektinis_03
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas:" + Pavadinimas);
            Console.WriteLine("Jis randasi adresu:" + Adresas);
            Console.WriteLine("-------------");
            Console.WriteLine("Jame turimos knygos:");
            Console.WriteLine("---------");

            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }

            Console.WriteLine("-------");
            Console.WriteLine("didziausia knyga:");

        }
        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai>didziausia.Puslapiai)
                {
                    didziausia = knyga;
                }
                
            }
            return didziausia;
        }

        public double BendraApyvarta()
        {
            var bendra = 0.0;
            foreach (var knyga in Knygos)
            {
                bendra += knyga.Apyvarta();
            }
            return bendra;
        }
    }
}
