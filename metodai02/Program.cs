using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai02
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.informacija();


        }

        public void informacija()
        {
            var vardas = "tomas";
            var pavarde = "tomosiunas";
            var amzius = 28;
            var alga = "900 euru";
            var etatas = "pilns etatas";
            var specializacija = "kriminalistas";
            Console.WriteLine("policininko vardas ir pavarde"+" "+vardas+" "+pavarde+" "+"kuriam yra"+" "+amzius+" "+ "ir jis uzdirba"+" "+alga+" "+"dirbdamas"+" "+etatas+" "+"ir jo specializacija" +" "+specializacija );
        }
    }
}
