using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main()
        {
            int num;
            int prime = 1;
            Console.WriteLine("Enter the number");
            num = Convert.ToByte(Console.ReadLine());
            for(int n=2;n<num;n++)
            {
                if ((num % n) == 0)
                {
                    prime = 0;
                }

            }
            if (prime == 1)
                Console.WriteLine("It is a prime number");
            else
                Console.WriteLine("It is not a prime number");


        }
    }
}
