using System;
using System.Collections.Generic;

namespace Labs_14_Iterfaces
{
    class Program
    {
        static void Main()
        {
            Child c = new Child();
            c.DoThis();
        }
    }
    //Interface to FORCE A CERTAIN BEHAVIOUR
    interface ITools
    {
        int x { get; set; }
        void MustUseThisTool1();
        void MustUSeThisTool2();
    }
    class Parent { }
    // Child has only one parent
    class Child : Parent, ITools
    {
        public int x { get; set; }
        public void MustUseThisTool1()
        {
            Console.WriteLine("using tool1");
        }

        public void MustUSeThisTool2()
        {
            Console.WriteLine("Using tool2");
        }
    }

    //concrete class 
    class Child : Parent
    {
        public override void Dothis() { }
    }

    class Real : Child, IComparable
    {
        public int CompareTo(object real)
        {
            return 1;
        }
    }
}
