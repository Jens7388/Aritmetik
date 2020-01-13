using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 30;
            int secondNumber = 15;
            int plusResult = firstNumber + secondNumber;
            int minusResult = firstNumber - secondNumber;
            int multiplyResult = firstNumber * secondNumber;
            int divideResult = firstNumber / secondNumber;

            Console.WriteLine($"Plus: {firstNumber} + {secondNumber} = {plusResult}");
            Console.WriteLine($"Minus: {firstNumber} - {secondNumber} = {minusResult} ");
            Console.WriteLine($"Gange: {firstNumber} * {secondNumber} = {multiplyResult}");
            Console.WriteLine($"Divider: {firstNumber} / {secondNumber} = {divideResult}");
            Console.ReadLine();
        }
    }
}
