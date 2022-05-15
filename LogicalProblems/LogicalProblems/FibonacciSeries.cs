using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int a = 0, b = 1, c, i;
            Console.WriteLine("Enter the number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " " );

            for (i = 2; i < Num; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }   
        }
        
    }
}
