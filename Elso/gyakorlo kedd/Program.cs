using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo_kedd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szamot");
            string v = Console.ReadLine();
            int a = Convert.ToInt32(v);
           /* int seged = 1;
            do
            {
                Console.Write(seged);
                Console.Write(" ");
                seged++;
            } while (seged <= a);*/

            Console.WriteLine("Adj meg egy másik szamot");
            string v2 = Console.ReadLine();
            int b = Convert.ToInt32(v2);

            if (a > b)
            {
                do
                {
                    Console.Write(b);
                    Console.Write(" ");
                    b++;
                } while (a >= b);
            }
            else if (b > a)
            {
                do
                {
                    Console.Write(a);
                    Console.Write(" ");
                    a++;
                } while (b >=a);
            }
            else
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
