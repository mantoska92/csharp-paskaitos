using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektinis_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Haris Poteris", "Rawling",500,"vaikiska",12,30),
                new Knyga("pavadinimas" ,"autorius", 400,"drama",26,800),
                new Knyga("salala", "opapa", 30,"nesamone",15,20),
            });

            knygynas.Isvedimas();
        }
    }
}
