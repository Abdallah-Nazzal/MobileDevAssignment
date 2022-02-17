using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevAssignment
{
    internal class NumberFinder
    {
        public void FindNumber()
        {
            Console.WriteLine("Please enter a text");
            string text = Console.ReadLine();
            string firstDigit = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    firstDigit += text[i];
                    if (!Char.IsDigit(text[i + 1]))
                        break;
                }
            }
            Console.WriteLine(firstDigit);
        }
    }
}
