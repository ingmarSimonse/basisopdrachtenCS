using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basisopdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length == 3)
            {
                if (!double.TryParse(args[0], out double arg1))
                {
                    Console.WriteLine("Please enter a number");
                }
                if (!double.TryParse(args[2], out double arg3))
                {
                    Console.WriteLine("Please enter a number");
                }
                string arg2 = args[1];
                double sum;
                switch (arg2)
                {
                    case "+":
                        sum = arg1 + arg3;
                        break;
                    case "-":
                        sum = arg1 - arg3;
                        break;
                    case "*":
                        sum = arg1 * arg3;
                        break;
                    case "/":
                        sum = arg1 / arg3;
                        break;
                    default:
                        sum = 0;
                        break;
                }
                string output = arg1.ToString() + " " + arg2 + " " + arg3.ToString() + " = " + sum.ToString();
                Console.WriteLine(output);
            } else
            {
                Console.WriteLine("Please enter a sum: 3 * 5");
            }
        }
    }
}
