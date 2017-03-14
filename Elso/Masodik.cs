using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string v;
            Console.Write("Adj meg egy szamot: ");
            v = Console.ReadLine();
            a = Convert.ToInt32(v);
            Console.Write("Adj meg meg egy szamot ami nagyobb az elsonel: ");
            v = Console.ReadLine();
            b = Convert.ToInt32(v);
            int c = b - a;
            Console.WriteLine("Talald ki mi a logika: ");
            Console.Write(c);
            Console.WriteLine("szamok 1-tol az elso megadottig:");
            int seged = 1;
            do {
                Console.Write( seged );
                Console.Write(" ");
                seged++; 
            }
            while (seged <= a);
            Console.WriteLine();
            Console.ReadKey();

         
        }
    }
}
