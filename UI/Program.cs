using LimitOfTypes;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
           string x = "10000000";

            var y = new LimitOfByte();

            byte result = y.GetUnSignedNumber(x);

            Console.WriteLine(result);
        }
    }
}
