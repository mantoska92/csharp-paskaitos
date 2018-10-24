using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace su_argumentais_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var progr = new Program();

            var vardas = "zivile";
            var pavarde = "neverbickiene";
            var amzius = 28;
            var profesija = "personalo specialiste";


            progr.informacija(vardas, pavarde, amzius, profesija);
            progr.informacija("as", "tu", amzius, "vartu paruosejas");
        }
        public void informacija(string vard, string pav, int amz, string prof)
        {
            Console.WriteLine(vard + " " + amz + " " + pav + " " + prof);
        }
    }
}
