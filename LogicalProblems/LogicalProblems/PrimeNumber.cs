using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            int count = 0;
            Console.WriteLine("Enter the number");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    count++;

                }

            }
            if (count == 2)
            {
                Console.WriteLine("The number is not a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Prime Number");
            }

        }
    }
}
