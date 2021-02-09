using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class assignment3c
    {
        static void Main()
        {
            int[] arr = new int[10];
            int count = 0;
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < 10; i++)
                Console.Write(arr[i] + "\t");
            for (int i = 0; i <10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    // If duplicate found then increment count by 1 
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("\nNumber of Duplicate elements are " + count);
        }
    }
}
