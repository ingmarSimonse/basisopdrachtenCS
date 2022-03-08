using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basisopdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 2)
            {
                int arg1;
                if (!int.TryParse(args[0], out arg1))
                {
                    Console.WriteLine("Please enter a number");
                }
                int arg2;
                if (!int.TryParse(args[1], out arg2))
                {
                    Console.WriteLine("Please enter a number");
                }
                int sum = arg1 + arg2;
                Console.WriteLine(arg1.ToString() + " + " + arg2.ToString() + " = " + sum.ToString());
            }
        }
    }
}
