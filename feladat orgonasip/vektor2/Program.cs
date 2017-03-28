using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5] { 1, 2, 5, 9, 45 };
            for(int i=0;i<v.Length; i++)
            {
                Console.Write(v[i] +",");
            }
            
            Console.ReadKey();
        }
    }
}
