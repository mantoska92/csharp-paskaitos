using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektinis_01
{
    class Lektuvas
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas() { }

        public Lektuvas(int sparnuIlgis, string pavadinimas,int vietos, string klase, int varikliuSkaicius,string varikioTipas)
        {
           this.SparnuIlgis = SparnuIlgis;
            Pavadinimas = pavadinimas; // this rodo i klase
            Vietos = vietos;
            Klase = klase;
            VarikliuSkaicius = varikliuSkaicius;
            VariklioTipas = varikioTipas;
            
        }
        

        

        public void Isvedimas()
        {
            Console.WriteLine("lektuvas {0} turi {1} vietu,jo sparnu ilgis yra{2}metru.", Pavadinimas, Vietos, SparnuIlgis);
            Console.WriteLine("jis priskiriamas {0} klasei,turi {1}tipo {2} variklius.", Klase, VariklioTipas, VarikliuSkaicius);
            Console.WriteLine();
        }

        public void VarikliuKiekis()

        {
            Console.WriteLine("bendras varikliu kiekis:"+ VarikliuSkaicius);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas();
            lektuvas1.Pavadinimas = "Boying";
            lektuvas1.Vietos = 600;
            lektuvas1.Klase = "Tarpatlantinis";
            lektuvas1.SparnuIlgis = 500;
            lektuvas1.VariklioTipas = "turbo";
            lektuvas1.VarikliuSkaicius = 4;

            lektuvas2.Pavadinimas = "kukuruznikas";
            lektuvas2.Vietos = 1;
            lektuvas2.Klase = "ukinis";
            lektuvas2.SparnuIlgis = 2;
            lektuvas2.VariklioTipas = "reaktyvinis";
            lektuvas2.VarikliuSkaicius = 1;


            Console.WriteLine(lektuvas1.Pavadinimas);
            Console.WriteLine(lektuvas2.SparnuIlgis);
            Console.WriteLine(lektuvas1.Klase);
            Console.WriteLine(lektuvas2.VariklioTipas);
            Console.WriteLine();

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();



            var lektuvas3 = new Lektuvas(5, "F15", 2, "naikintuvas", 2, "reaktyvinis");
            lektuvas3.Isvedimas();

                
        }
    }
}
