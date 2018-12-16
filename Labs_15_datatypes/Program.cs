using System;

namespace Labs_15_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01; //32bit 
            short num02; // 16bit
            long num03; // 64bit#

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            uint num04;
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            //decimal types
            float num05 = 1.23456F; // 32bit
            double num06 = 1.23456; //64bit; default
            decimal num09 = 1.23456M; //128 bit plus MONEY EXACTLY

            string string01 = "abc";
            //string is same as an array of characters 
            // ASCII ==> 0-127 basic characters
            // UNICODE UTF-8: similar to ASCII
            // UNICODE UTF-16: c# : Represent basic english plus 
            // characters from around the world eg chineese
            char char01 = 'f';
            char char02 = (char)102;
            Console.WriteLine(char01);
            Console.WriteLine(char02);
        }
    }
}
