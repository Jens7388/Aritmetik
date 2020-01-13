using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 34;
            int combinedNumbers = firstNumber + secondNumber;
            string firstText = "12";
            string secondText = "34";
            string combinedTexts = firstText + secondText;

            Console.WriteLine($"Tekst lagt sammen er: {combinedTexts}");
            Console.WriteLine($"Tal lagt sammen er: {combinedNumbers}");
            Console.WriteLine($"Tekst og tal lagt sammen er: {firstNumber + firstText}");
            Console.ReadLine();
        }
    }
}
