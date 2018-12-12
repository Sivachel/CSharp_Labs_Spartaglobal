using System;

namespace Labs_08_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance01 = new MyClass();
            instance01.DoThis();
            instance01.DoThis(10);
            instance01.DoThis("hi");
            //don't set default values
            instance01.DoThisAlso();
            //set values 
            instance01.DoThisAlso(100, "nice");

            int output = instance01.DoThisSometimes(out int output2);
            Console.WriteLine(output2);

        }
    }

    class MyClass
    {
        public void DoThis() { }
        public void DoThis(int x) { }
        public void DoThis(string y) { Console.WriteLine("hello"); }

        //set default values
        public void DoThisAlso(int x=5, string y = "h3llo")
        {
            Console.WriteLine("x is {0} and y is {1}", x, y);
        }

        public int DoThisSometimes(out int y)
        {
            y = 200;
            return 100;
        }
    }
}
