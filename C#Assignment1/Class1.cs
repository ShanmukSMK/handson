using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main()
        {
            float sum = 0;
            float avg = 0;
            for(int n=1;n<=20;n++)
            {
                //("Sum of first 20 natural numbers is:");
                sum += n;
                avg = sum / 20;
            }
            Console.WriteLine("Sum of first 20 natural numbers is:"+sum);
            Console.WriteLine("Average of first 20 natural numbers is:"+avg);
        }
    }
}
