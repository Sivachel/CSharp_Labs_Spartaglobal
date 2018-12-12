using System;

namespace Labs_08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANTIATE new object p 
            Parent p = new Parent();
            //static 
            Parent.DoThis();
            //instance
            p.Grow();
            Console.WriteLine(p.age);
        }
    }

    class Parent
    {
        public int age { get; set; }
        public void Grow()
        {
            age++;
        }
        public static void DoThis()
        {

        }
    }
}
