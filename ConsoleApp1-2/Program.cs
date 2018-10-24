using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
          
            var vardai = new[]
            {"marius",
            "zivile",
            "andrius",
            "remigijus",
            "laura",
            "auguste",
            "herkus",
            "ingrida"
            };

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(vardai[rnd.Next(0, vardai.Length)]);
                
                //vardai = rnd.Next(1, 6);
            }
        }
        

    }
}
