using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Mine gæt:
             1. -5 * 2 + (-6 * -2) = 4
             2. 11 + (-20) + 36 * (-8) = -297
             3. -1234567 + 9876543 = 8641976
             4. 2*(2+2-2-2) * 2 * 2 = 0
             5. 3,14 * 0 = 0
             6. 2,7 - 7,2 = - 5,5
             7. 2,7 * 0.1 + (-3.14 + 6 * 7,5) = 42,13
             */

            double results = 0;

            results = -5 * 2 + (-6 * -2);
            Console.WriteLine($"1. {results}");
            results = 11 + (-20) + 36 * (-8);
            Console.WriteLine($"2. {results}");
            results = -1234567 + 9876543;
            Console.WriteLine($"3. {results}");
            results = 2 * (2 + 2 - 2 - 2) * 2 * 2;
            Console.WriteLine($"4. {results}");
            results = 3.14 * 0;
            Console.WriteLine($"5. {results}");
            results = 2.7 - 7.2;
            Console.WriteLine($"6. {results}");
            results = 2.7 * 0.1 + (-3.14 + 6 * 7.5);
            Console.WriteLine($"7. {results}");
            Console.ReadLine();

        }
    }
}
