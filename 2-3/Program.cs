using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var markes = new List<string> { "bmw", "opel", "tata", "lada" };
            
            foreach (var marke in markes)
            {
                Console.Write(marke+ ",");
            }
            
        }
        
    }
}
