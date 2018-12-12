using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using Labs_02_dll;

namespace Labs_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");
            

            Labs_02_dll.Raj name = new Raj();
            name.anything = 1;
            Console.WriteLine(name.anything);
            Console.ReadLine();
        }
    }
}
