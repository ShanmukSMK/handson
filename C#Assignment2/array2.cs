using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class array2
    {
        static void Main()
        {
            int[,] matrix3 = new int[3, 3];
            int[,] matrix1 = new int[3, 3];
            //    { 1,2,3},
            //    { 1,2,3},
            //    { 1,2,3}
            //};
            int[,] matrix2 = new int[3, 3];
            //    {
            //    {1,2,3 },
            //    {1,2,3 },
            //    {1,2,3 }
            //    };
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write(matrix3[i, j] = matrix1[i, j] + matrix2[i, j]);
            //        }
            //        Console.WriteLine();
            //    }

            Console.WriteLine("Enter Numbers");
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
            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix2 is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of two matrices is");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++ )
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(matrix3[i, j] + "\t");
                }
                Console.WriteLine();
            }




        }
    }
}
