using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast antallet af sekunder, som skal omregnes til minutter og sekunder: ");
                string inputSeconds = Console.ReadLine();
                int.TryParse(inputSeconds, out int seconds);
                int minutes = seconds / 60;
                int remainingSeconds = seconds % 60;
                Console.WriteLine($"{seconds} svarer til {minutes} minutter og {remainingSeconds} sekunder");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
