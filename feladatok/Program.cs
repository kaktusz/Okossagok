
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatok
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  1. Írjon egy programot, ami leosztályoz egy maximálisan 100 pontos dolgozatot az 50, 65, 80,
              90 ponthatárok szerint!A határérték a jobb jegyhez tartozik.Ha a pontszám negatív vagy
            száznál nagyobb, akkor a program írja ki, hogy hibás az adat!

              Console.WriteLine("Add meg a dolgozat pontszámát!");
              string s = Console.ReadLine();
              int pont = Convert.ToInt32(s);

              if (pont >100 || pont <0)
              {
                  Console.WriteLine("Hibás adat");
              }

              else
              {

                if ((pont <=100 || (pont>= 90 )) && !(pont < 90))
                {
                  Console.WriteLine("A " +pont +" pontszám Ötös értékelésnek felel meg.");
               }
                else if ((pont < 90 || pont >= 80) && !(pont <80))
                      {
                  Console.WriteLine("A " + pont + " pontszám Négyes értékelésnek felel meg.");
               }
               else if ((pont < 80 || pont >= 65) && !(pont < 65))
                {
                  Console.WriteLine("A " + pont + " pontszám Hármas értékelésnek felel meg.");
               }
                else if ((pont < 65 || pont >= 50) && !(pont < 50))
                {
                  Console.WriteLine("A " + pont + " pontszám Kettes értékelésnek felel meg.");
               }
                  else if ((pont < 50 || pont >= 0) )
                  {
                      Console.WriteLine("A " + pont + " pontszám Egyes értékelésnek felel meg.");
                  }

              }*/

            /* 1.a Írjon egy programot, ami leosztályoz egy maximálisan 100 pontos dolgozatot az 50, 65, 80,
           90 ponthatárok szerint!A határérték a jobb jegyhez tartozik.Ha a pontszám negatív vagy
         száznál nagyobb, akkor a program írja ki, hogy hibás az adat! - addig kéri a pontszámot míg az 100 és 0 közé nem esik*/

            //Console.WriteLine("Add meg a dolgozat pontszámát!");
            //string s = Console.ReadLine();
            int pont /*= Convert.ToInt32(s)*/;
            int pont2;


            //if (pont > 100 || pont < 0)
            {
                do
                {

                    Console.WriteLine("Add meg a dolgozat pontszámát!");
                    string s2 = Console.ReadLine();
                    pont2 = Convert.ToInt32(s2);
                    pont = pont2;
                    Console.WriteLine("Hibás adat");
                } while (pont2 > 100 || pont2 < 0);
            }
            if (pont <= 100 && pont >= 0)
            {

                if ((pont <= 100 || (pont >= 90)) && !(pont < 90))
                {
                    Console.WriteLine("A " + pont + " pontszám Ötös értékelésnek felel meg.");
                }
                else if ((pont < 90 || pont >= 80) && !(pont < 80))
                {
                    Console.WriteLine("A " + pont + " pontszám Négyes értékelésnek felel meg.");
                }
                else if ((pont < 80 || pont >= 65) && !(pont < 65))
                {
                    Console.WriteLine("A " + pont + " pontszám Hármas értékelésnek felel meg.");
                }
                else if ((pont < 65 || pont >= 50) && !(pont < 50))
                {
                    Console.WriteLine("A " + pont + " pontszám Kettes értékelésnek felel meg.");
                }
                else if ((pont < 50 || pont >= 0))
                {
                    Console.WriteLine("A " + pont + " pontszám Egyes értékelésnek felel meg.");
                }
            }
            Console.ReadKey();
        }
    }
}
