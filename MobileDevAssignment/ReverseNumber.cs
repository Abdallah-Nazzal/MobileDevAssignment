using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevAssignment
{
    internal class ReverseNumber
    {
       public void Reverse()
        {
            Console.Write("Enter a number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (number > 0)
            {
                int temp = number % 10;
                reverse = (reverse * 10) + temp;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is {0}", reverse);
        }
    }
}
