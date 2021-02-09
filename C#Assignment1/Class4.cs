using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main()
        {
            int number;
            int n = 1;
            Console.WriteLine("Enter a Number");
            number = Convert.ToByte(Console.ReadLine());
            for(n=1;n<=10;n++)
            {

                Console.WriteLine(number+"*"+n+"="+ number * n);
            }
        }
    }
}
