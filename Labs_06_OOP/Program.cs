using System;

namespace Labs_06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.age = 22;
            p.name = "fred";
            Console.WriteLine(p.getCousins());
            p.setCousins(5);
            Console.WriteLine(p.getCousins());

            Child c = new Child();
            c.age = 1;
        }

        class Parent 
        {
            // field - by default its private
            public int age = 0;
            //property get;set;
            public string name { get; set; }
            private int _numberOfCousins;
            //method 
            public int getCousins()
            {
                return this._numberOfCousins;
            }
            public void setCousins(int x)
            {
                if (x > 0)
                {
                    this._numberOfCousins = x;
                }
            }

            //property expanded code 
            public String employment
            {
                get
                {
                    return this.employment;
                }
                set
                {
                    this.employment = value;
                }
            }
        }

        class Child : Parent
        {

        }
    }
}
