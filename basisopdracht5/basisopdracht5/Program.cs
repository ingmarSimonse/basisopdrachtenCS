using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basisopdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                foreach (string entry in Directory.GetDirectories(args[0]))
                {
                    Console.WriteLine(entry);
                }
            }
        }
    }
}
