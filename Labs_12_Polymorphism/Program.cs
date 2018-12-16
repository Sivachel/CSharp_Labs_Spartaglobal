using System;

namespace Labs_12_Polymorphism
{
    class Program
    {
        static void Main()
        {
            Parent p = new Parent();
            p.HaveAParty();
            Child c = new Child();
            c.HaveAParty();
            Teenager t = new Teenager();
            t.HaveAParty();
        }
    }

    class Parent
    {
        //parent IMPLEMENTATION
        // virtual keyword allows to override in the child clas
        internal virtual void HaveAParty()
        {
            Console.WriteLine("Parent is having a dinner party");
        }
    }
    class Child : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Child is having a party");
        }
    }

    class Teenager : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Teenager is having a party");
            base.HaveAParty();
        }
    }
}
