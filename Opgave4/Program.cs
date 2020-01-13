using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 3;
            int moduloResult = firstNumber % secondNumber;
            double intResult = firstNumber / secondNumber;
            double doubleResult = (double)firstNumber / (double)secondNumber;

            Console.WriteLine($"Division med int datatype gemt i en double: \n {firstNumber} / {secondNumber} = {intResult}");
            Console.WriteLine($"Division med konverterede int til double datatype: \n {firstNumber} / {secondNumber} = {doubleResult}");
            Console.WriteLine($"Forkortet til 2 decimaler: \n {firstNumber} / {secondNumber} = {doubleResult,2:f}");
            Console.WriteLine($"Modulus: \n {firstNumber} % {secondNumber} = {moduloResult}");
            Console.ReadLine();
        }
    }
}
