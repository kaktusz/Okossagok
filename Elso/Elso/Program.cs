using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            int szam2;
            string beolvasott;

            Console.Write("elso szam: ");
            beolvasott = Console.ReadLine();
            szam1 = Convert.ToInt32(beolvasott);
            szam1 = szam1+3;
            Console.Write("megadott szam +3 = ");
            Console.WriteLine(szam1);
            Console.ReadKey();
                        
        }
    }
}
