using System;

namespace Labs_13_abstractrevisit
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.DoThis();
        }
    }

    public abstract class Parent
    {
        public abstract void DoThis();
    }
    // concreate class
    class Child : Parent
    {
        public override void DoThis()
        {
        }
    }
}
