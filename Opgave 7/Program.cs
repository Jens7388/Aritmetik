using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv 5 personers højde i cm, og se deres gemmensnitlige højde. ");
                Console.Write("Første højde: ");
                int firstHeight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anden højde: ");
                int secondHeight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Trejde højde: ");
                int thirdHeight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Fjerde højde: ");
                int fourthHeight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Femte højde: ");
                int fifthHeight = Convert.ToInt32(Console.ReadLine());
                int averageHeight = (firstHeight + secondHeight + thirdHeight + fourthHeight + fifthHeight) / 5;
                Console.WriteLine($"Personernes gemmensnitshøjde er: {averageHeight}");
                Console.ReadLine();
            }
        }
    }
}
