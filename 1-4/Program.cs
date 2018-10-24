using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var skaiciai1 = new[] { 1, 2, 3, 45, 47 };
            var skaiciai2 = new[] { 7, 8, 9, 10, 15 };
            var skaiciai3 = new[] { 14, 15, 18, 17, 19 };
            var skaicius1 = skaiciai1[rnd.Next(skaiciai1.Length)];
            var skaicius2 = skaiciai2[rnd.Next(skaiciai2.Length)];
            var skaicius3 = skaiciai3[rnd.Next(skaiciai3.Length)];
            if (skaicius1>skaicius2&&skaicius1>skaicius3)
            {
                Console.WriteLine(skaicius1);
            }
            else if (skaicius2>skaicius1&&skaicius2>skaicius3)
            {
                Console.WriteLine(skaicius2);
            }
            else if (skaicius3>skaicius1&&skaicius3>skaicius2)
            {
                Console.WriteLine(skaicius3);
            }
        }
        

    }
}
