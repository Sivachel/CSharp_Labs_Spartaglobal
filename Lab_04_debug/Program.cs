using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_04_debug
{
    class Program
    {
       public static void Main(string[] args)
        {
            int x = 0;
            int z = 0;

            for (int i = 0; i < 10; i++)
            {
                x = i * i;
                z += x;
            }
            Console.WriteLine("total {0}", z);
        }
    }
}
