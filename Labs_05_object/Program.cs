using System;
using System.Dynamic;

namespace Labs_05_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1 - Manually create object in C#
            ///* Start
            object object01 = new
            {
                name = "Raj",
                age = 22
            };
            Console.WriteLine(object01);
            // end *\

            //Method 2
            ///* Start
            dynamic object02 = new ExpandoObject();
            object02.name = "raj";
            object02.age = 23;
            Console.WriteLine(object02.name);
            //*\ end
        }
    }
}
