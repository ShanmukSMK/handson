using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class assignment3b
    {
        static void Main()
        {
            int customer_id, units_consumed;
            double charge, surcharge = 0, bill, total_bill;
            string customer_name;
            Console.Write("Customer ID :");
            customer_id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Customer Name:");
            customer_name = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            units_consumed = Convert.ToInt16(Console.ReadLine());
            if (units_consumed < 200)
                charge = 1.20;
            else if (units_consumed >= 200 && units_consumed < 400)
                charge = 1.50;
            else if (units_consumed >= 400 && units_consumed < 600)
                charge = 1.80;
            else
                charge = 2.00;
             bill = units_consumed * charge;
            if (bill > 400)
                surcharge = bill * 15 / 100.0;
            total_bill = bill + surcharge;
            if (total_bill < 100)
                total_bill = 100;
            Console.WriteLine("Electricity Bill");
            Console.WriteLine("Customer ID:\t"+customer_id);
            Console.WriteLine("Customer Name:\t"+ customer_name);
            Console.WriteLine("Unit Consumed:\t"+ units_consumed);
            Console.WriteLine("Amount Charges @Rs."+charge+" per unit:"+bill);
            Console.WriteLine("Surchage Amount: "+ surcharge);
            Console.WriteLine("Net Amount Paid By the Customer: " + total_bill);
        }
    }
}
