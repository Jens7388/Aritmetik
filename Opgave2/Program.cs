using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 50;
            int secondNumber = 30;
            int thirdNum = 5;
            int result = firstNumber + secondNumber - thirdNum;
            Console.WriteLine($"Resultatet af {firstNumber} + {secondNumber} - {thirdNum} er {result}");
            Console.ReadLine();
        }
    }
}
