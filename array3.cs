using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class array3
    {
        static void Main()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<10;i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < 10; i++)
                Console.Write(arr[i]+"\t");
            int max = arr[0];
            int pos=0;
            for(int i=1;i<10;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                    pos = i;
                }
            }
            Console.WriteLine("\nMaximum element in the array is\n" + max);
            Console.WriteLine("\nits position is\n" + pos);
        }
    }
}
