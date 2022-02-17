using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevAssignment
{
    internal class DigitAnalyzer
    {
        public void GetLargestDigit()
        {
			int number, temp, largestDigit = 0;
			Console.Write("Enter a number:");
			number = Convert.ToInt32(Console.ReadLine());

			while (number > 0)
			{
				temp = number % 10;
				if (largestDigit < temp)
				{
					largestDigit = temp;
				}
				number = number / 10;
			}
			Console.WriteLine("Largest digit:" + largestDigit);
		}
    }
}
