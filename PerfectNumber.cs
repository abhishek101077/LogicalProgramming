using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    { 
        public static void solution()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the perfect numbers within a given of range");
            Console.WriteLine("Input the stating range or number");
            mn=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range or number");
            mx = Convert.ToInt32(Console.ReadLine());

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }

            }

                    
            
    }
}
