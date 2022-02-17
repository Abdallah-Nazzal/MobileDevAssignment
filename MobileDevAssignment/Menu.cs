using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileDevAssignment;

namespace MobileDevAssignment
{
    internal class Menu
    {
        public bool MainMenu()
        {
            LargestNumber largestNumber = new LargestNumber();
            ReverseNumber reverseNumber = new ReverseNumber();
            DigitAnalyzer digitAnalyzer = new DigitAnalyzer();
            NumberFinder numberFinder = new NumberFinder();
            Console.WriteLine("Welcome to this program!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1) Find largest number");
            Console.WriteLine("2) Reverse a given number");
            Console.WriteLine("3) Find largest digit of a number");
            Console.WriteLine("4) Find the first number of a given text");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    largestNumber.GetLargestNumber();
                    return true;
                case "2":
                    reverseNumber.Reverse();
                    return true;
                case "3":
                    digitAnalyzer.GetLargestDigit();
                    return true;
                case "4":
                    numberFinder.FindNumber();
                    return true;
                default:
                    return true;
            }
        }
    }
}
