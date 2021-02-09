using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class array5
    {
        static void Main()
        {
            int[,] matrix1 = new int[3, 3];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix1 is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += matrix1[i, j];
                }
                Console.WriteLine("Sum of elements in the row" + i + "\tis\t" + sum);
            }
        }
    }
}
