using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Adj meg egy szamot: ");
            string v =Console.ReadLine();
            a = Convert.ToInt32(v);
            if (a < 0){
                Console.WriteLine("A megadott szam negativ.");
            }
            else if (a > 0){
                Console.WriteLine("A megadott szam pozitiv.");

            }
            else {
                Console.WriteLine("A megadott szam 0.");
            }
            Console.Write("Adj meg egy szamot: ");
            v = Console.ReadLine();
            a = Convert.ToInt32(v);
            if (a %2 == 0)
            {
                Console.WriteLine("A megadott szam paros");
            }
            else
            {
                Console.WriteLine("A megadott szam paratlan");
            }

            Console.Write("Adj meg egy szamot: ");
            v = Console.ReadLine();
            a = Convert.ToInt32(v);
            if (a <0 && a%2==0){
                Console.WriteLine("A megadott szam Negativ páros szám");
            }
            else if(a < 0 && a % 2 != 0)
            {
                Console.WriteLine("A megadott szam Negativ páratlan szám");
            }
            else if( a >0 && a%2==0)
            {
                Console.WriteLine("A megadott szam Pozitiv páros szám");
            }
            else if (a > 0 && a % 2 != 0)
            {
                Console.WriteLine("A megadott szam Pozitiv páratlan szám");
            }
            else
            {
                Console.WriteLine("Nullat adtal meg");
            }
            Console.ReadKey();
        }
    }
}
