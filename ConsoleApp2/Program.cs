using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 6;
            ucgen.B = 5;
            ucgen.C = 4;
            Console.WriteLine(" A'nin degeri = {0} ", ucgen.A);
            Console.WriteLine(" B'nin degeri = {0}", ucgen.B);
            Console.WriteLine(" C'nin degeri = {0}", ucgen.C);
        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;
        public int A 
        { 
            get { return a; } 
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı bilgi");
                else
                    a= value;
            } 
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı bilgi");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set 
            {
                if (value <= 0)
                    Console.WriteLine("hatalı bilgi");
                else
                    c = value;
            }
        }
    }
}
