using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave8
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int price = 0;

                Console.WriteLine("Indtast en af følgende varer, og se dens pris med moms, uden moms, og momsbeløbet:");
                Console.WriteLine("Maelk");
                Console.WriteLine("Fjernsyn");
                Console.WriteLine("Torsk");
                Console.WriteLine("Computer");
                Console.WriteLine("Motorsav");
                Console.WriteLine("Sodavand");
                string input = Console.ReadLine();

                //viser og udregner en vares pris/momsbeløb efter gyldigt input, og giver mulighed for at købe den
                if(input == "Maelk" || input == "maelk")            
                {
                    price = 20;
                    Console.WriteLine("\nMaelk:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} kr");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");
                }
                else if(input == "Fjernsyn" || input == "fjernsyn" || input == "tv" || input == "TV")
                {
                    price = 4000;
                    Console.WriteLine("\nFjernsyn:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} kr");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");
                }
                else if(input == "Torsk" || input == "torsk")
                {
                    price = 300;
                    Console.WriteLine("\nTorsk:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} kr");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");
                }
                else if(input == "Computer" || input == "computer" || input == "pc" || input == "PC")
                {
                    price = 4500;
                    Console.WriteLine("\nComputer:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} ");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");
                }
                else if(input == "Motorsav" || input == "motorsav")
                {
                    price = 2000;
                    Console.WriteLine("\nMotorsav:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} kr");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");

                }
                else if(input == "Sodavand" || input == "sodavand")
                {
                    price = 10;
                    Console.WriteLine("\nSodavand:");
                    Console.WriteLine($"Pris med moms: {price} kr");
                    Console.WriteLine($"Pris uden moms: {price * 0.75} kr");
                    Console.WriteLine($"Momsbeløb: {price * 0.25} kr");
                    Console.Write("Skriv et beløb her hvis du ønsker at købe varen:");
                }
                else
                {
                    Console.WriteLine("Ugyldig vare, prøv igen");
                    Console.ReadLine();
                    Console.Clear();
                }

                //udregner hvor meget man får i retur, hvis beløbet er tilstrækkeligt
                string paymentInput = Console.ReadLine();
                int.TryParse(paymentInput, out int paymentAmount);
                int returnAmount = paymentAmount - price;

                if(paymentAmount >= price)
                {
                    Console.WriteLine($"Vare købt! Du får {returnAmount} kr tilbage.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(paymentAmount == 0)
                {
                    Console.WriteLine("Ugyldigt beløb!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Beløbet er ikke tilstrækkeligt til at du kan købe denne vare. Spar op, og kom igen");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
