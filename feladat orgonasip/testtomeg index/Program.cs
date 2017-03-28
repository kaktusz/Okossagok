using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomeg_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int suly;
            do
            {
                Console.Write("Add meg a súlyodat kilogramban: ");
                string v1 = Console.ReadLine();
                suly = Convert.ToInt32(v1);
            } while (suly > 0);
            Console.Write("Add meg a magasságodat centiméterben: ");
            string v2 = Console.ReadLine();
            double magassag = Convert.ToDouble(v2);
            double bmi = suly / (magassag * magassag);
            if (bmi < 18)
            {
                Console.WriteLine("Annyira sovány vagy, hogy fáj.");
            }
            else if (bmi>=18 || bmi < 25)
            {
                Console.WriteLine("Ideális a súlyod csak így tovább");
            }
            else if (bmi >=25  || bmi < 30)
            {
                Console.WriteLine("Barátom, ideje behúzni a gatya madzagot, kezdesz elhizni");
            }

            else
            {
                Console.WriteLine("Tessék sportolni, elhíztál");
            }
            Console.ReadKey();
        }
    }
}
