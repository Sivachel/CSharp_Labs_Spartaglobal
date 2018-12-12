using System;

namespace Labs_10_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Mercedes { }

    class SClass : Mercedes { }

    class SLS : SClass { }

    // Don't chnage nay further
    sealed class SLSSport : SClass { }
    
    class enthusiasticEngineer : SLSSport { }// cannot derive becuase SLSSport is sealed
    class enthusiasticEngineer : SLS { }// can derive 
}
