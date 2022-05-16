using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0, n;
            Console.WriteLine("enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");                
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");               
            }
        }
    }
}
