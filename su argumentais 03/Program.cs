using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace su_argumentais_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.skaiciuoti(4, 3);
            prog.skaiciuoti(10, 5);
            prog.skaiciuoti(3, 5);
            prog.skaiciuoti(9, 9);
        }
        public void skaiciuoti(int a,int b)
        {
            sudetis(a, b);
            atimtis(a, b);
            daugyba(a, b);
            dalyba(a, b);
            Console.WriteLine();
        }
        public void sudetis(int a,int b)
        {
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
        }
        public void atimtis(int a,int b)
        {
            Console.WriteLine("{0}-{1}={2}",a,b,a-b);
        }
        public void daugyba(int a, int b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        }
        public void dalyba(int a,int b)
        {
            Console.WriteLine("{0}/{1}={2}",a,b,a/b);
        }
    }
}
