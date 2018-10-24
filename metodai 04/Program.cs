using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p = new Program();
            p.pasisveikinimas();
        }
        public void pasisveikinimas()
        {
            Console.WriteLine("iveskite savo varda");
            var vardas = Console.ReadLine();

            Console.WriteLine("labas"+ " " +vardas );
        }  


    }

}
