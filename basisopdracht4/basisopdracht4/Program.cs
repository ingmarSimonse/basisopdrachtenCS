using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basisopdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 21; i++)
            {
                sb.Append(i.ToString() + ":");
                int index = i;
                if (i > 10)
                {
                    index = 20 - i;
                }
                for (int f = 0; f < index + 1; f++)
                {
                    _ = (f % 2 != 0) ? sb.Append($" odd({f})") : sb.Append($" even({f})");
            }
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
