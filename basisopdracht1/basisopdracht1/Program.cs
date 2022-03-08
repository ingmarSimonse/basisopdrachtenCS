using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basisopdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = DateTime.Now.ToString("dd MMMM yyyy - HH:mm:ss");
            Console.WriteLine(date);
            if (args != null && args.Length > 0)
            {
                Console.WriteLine($"Welkom {args[0]}");
            } else
            {
                Console.WriteLine("Geef je naam in als argument");
            }
        }
    }
}
