
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Készítsen konzolos alkalmazást, amely mezőgazdasági jóslást végez. A program kérje be az elvetett búza mennyiségét tonnában. 
             * Ez alapján számolja ki egy véletlenszerűen generált szorzóval (5-15) a várható hozamot, és írja ki a mennyiségét. A szorzó alapján elemezze ésírja ki, 
             * hogy milyen év várható: átlag alatti (5-8), átlagos év (9-12), átlag feletti (13-15).
             */

            Console.WriteLine("Add meg a búza mennyiségét tonnában:");
            string s=Console.ReadLine();
            int tomeg = Convert.ToInt32(s);
            Random r = new Random();
            int szorzo = r.Next(5, 15);

            int hozam = szorzo * tomeg;

            Console.WriteLine( "A várható hozam: " + hozam +"tonna");
            if (szorzo >=5 && szorzo<=8)
            {
                Console.WriteLine("Átlag alatti év várható");
            }
            if (szorzo >= 9 && szorzo <= 12)
            {
                Console.WriteLine("Átlagos év várható");
            }
            if (szorzo >= 13 && szorzo <= 15)
            {
                Console.WriteLine("Átlag feletti év várható");
            }
            Console.WriteLine(szorzo +"," +tomeg +", " +hozam);

           // int hozam = r * tomeg;
            Console.ReadKey();
           
        }
    }
}
