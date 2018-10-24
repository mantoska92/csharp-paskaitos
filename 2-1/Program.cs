using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int> {3 , 2, 9, 5, 7 };
            skaiciai.Add(3);
            skaiciai.Add(2);
            skaiciai.Add(9);
            skaiciai.Add(5);
            skaiciai.Add(7);
            Console.WriteLine("maziausias:"+skaiciai.Min());
        }
    }
}
