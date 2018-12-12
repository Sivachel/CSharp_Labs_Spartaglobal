using System;

namespace Labs_09_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class HolidayPlans
    {
        //Ok 
        void DoThis()
        {
            //code here to visit venice 
        }

        //Incompplete travel plans
        public abstract void Travel();
    }

    class HolidayPlansComplete : HolidayPlans
    {
        public override void Travel()
        {
            //code here travel plans -Complete1!!!!
        }
    }
}
