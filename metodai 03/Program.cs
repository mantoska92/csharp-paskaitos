using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr = new Program();
            pr.Pirmas();
            pr.Antras();
            pr.Trecias();

        }

        public void Pirmas()
        {
            Console.WriteLine("-pirmas");
        }
        public void Antras()
        {
            Console.WriteLine("-antras ");
        }
        public void Trecias()
        {
            Console.WriteLine("-trecias");
        }
    }
}
