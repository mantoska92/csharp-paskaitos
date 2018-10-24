using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string> { "andrius", "simas", "tomas" };
            vardai.Add("andrius");
            vardai.Add("simas");
            vardai.Add("tomas");
            Console.WriteLine("pirmas ir antras vardai: {0} {1}", vardai[0], vardai[1]);
            Console.WriteLine();
        }
    }
}
