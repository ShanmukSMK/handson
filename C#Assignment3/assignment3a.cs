using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class assignment3a
    {
        static void Main()
        {
            int phy_marks, chem_marks, math_marks;
            Console.Write("Marks obtained in Physics :");
            phy_marks = Convert.ToInt16(Console.ReadLine());
            Console.Write("Marks obtained in Chemistry :");
            chem_marks = Convert.ToInt16(Console.ReadLine());
            Console.Write("Marks obtained in Mathematics :");
            math_marks = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Total marks of Maths, Physics and Chemistry is\t"+ (math_marks + phy_marks + chem_marks));
            Console.WriteLine("Total marks of Maths and  Physics is\t"+ (math_marks + phy_marks));

 
            if (math_marks >= 65 && phy_marks >= 55 && chem_marks >= 50)
            {
                if ((math_marks + phy_marks + chem_marks) >= 180 || (math_marks + phy_marks) >= 140)
                    Console.Write("The  candidate is eligible for admission.\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            }
            else
                Console.Write("The candidate is not eligible.\n\n");
        }
    }
}
   
