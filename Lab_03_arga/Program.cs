using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_arga
{
    class Program
    {
        static void Main(string[] args)
        {
           //iterate over the array with FOREACH LOOP
           // for every item in array, deal with it one by one 
           // call it 'item' everytime 
           foreach(string item in args)
            {
                Console.WriteLine("item is -" + item);
            }
        }
    }
}
