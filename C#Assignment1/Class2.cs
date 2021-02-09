using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main()
        {
            Console.WriteLine("Even Numbers from 1 to 50");
            for(int n = 1; n <= 50;n++)
            {
                if(n%2==0)
                Console.WriteLine(n);
            }
            
        }

    }
}
