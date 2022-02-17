using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevAssignment
{
    internal class LargestNumber
    {
        public void GetLargestNumber()
        {
            Console.Write("Please enter the number of elemnts:");
            int size = Convert.ToInt32(Console.ReadLine());
            List<double> numbers = new List<double>();
            double num;
            for (int i = 0; i < size; i++) 
            {
                num = Convert.ToDouble(Console.ReadLine());
                numbers.Add(num);
            }
            for(int i = 0; i<numbers.Count;i++)
            {
                if(numbers[0] < numbers[i])
                {
                    numbers[0] = numbers[i];
                }
            }
            Console.WriteLine("Your lragest number is: " + numbers[0]);
        }
    }
}
