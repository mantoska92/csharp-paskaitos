using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var medziai = new string[]
            {
                "berzas",
                "uosis",
                "liepa",
                "kedras"
            };



            for (int i = 0; i < medziai.Length; i++)
            {
                Console.WriteLine("- " + medziai[i]);

            }
        }
    }
}
