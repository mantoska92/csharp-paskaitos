using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektinis_03
{
    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }

        public Knyga(string pavadinimas, string autorius, int puslapiai, string zanras,double kaina,int kiekis)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Puslapiai = puslapiai;
            Zanras = zanras;
            Kaina = kaina;
            Kiekis = kiekis;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas:"+Pavadinimas);
            Console.WriteLine("Autorius:"+Autorius);
            Console.WriteLine("Puslapiu skaicius:" +Puslapiai);
            Console.WriteLine("Zanras:" +Zanras);
            Console.WriteLine("kaina" + Kaina + "eur");
            Console.WriteLine("Yra sios knygos vienetu:" +Kiekis);
            Console.WriteLine("pardavus visus vienetus gautusi {0} eur apyvartos",Apyvarta());
            Console.WriteLine();
        }

        public double Apyvarta()
        {
            return Kiekis * Kaina;
        }
    }
}
