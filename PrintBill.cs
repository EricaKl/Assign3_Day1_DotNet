using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign3
{
    internal class PrintBill
    {
        public void BillDetails(string Custname, int CId, float unit)
        {
            float charge = 0.00f;
            float amount = 0.00f;
            float surcharge = 0.00f;
            float totalamount = 0.00f;
            if(unit <= 199)
            {
                charge = 1.20f;
                amount = unit * charge;
                totalamount = amount;                    
            }
            else if(unit >=200 && unit<400)
            {
                charge = 1.50f;
                amount = unit * charge;
               totalamount = amount;

            }
            else if(unit>=400 &&unit<600)
            {
                charge = 1.80f;
               // amount = charge * unit;
                surcharge = (15 * charge * unit) / 100;
                amount = charge * unit;
                totalamount = amount  + surcharge;

            }
            else if(unit>=600)
            {
                charge = 2.00f;
                surcharge = (15 * charge * unit) / 100;
                amount = charge * unit;
                totalamount = amount + surcharge;

            }
            Console.WriteLine($"Customer IDNo : {CId}");
            Console.WriteLine($"Customer Nmae : {Custname}");
            Console.WriteLine($"unit consumed : {unit}");
            Console.WriteLine($"Amount Charges @Rs. {charge} per unit : {amount} ");
            Console.WriteLine($"Surcharge Amount : {surcharge}");
            Console.WriteLine($"Net Amount Paid By the Customer : {totalamount}");
        }
        static void Main()
        {
            string custname;
            int CId;
            float unit;
            Console.WriteLine("Enter your Name");
            custname = Console.ReadLine();
            Console.WriteLine("Enter your Customer Id");
            CId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter unit");
            unit = float.Parse(Console.ReadLine()); 
            PrintBill p = new PrintBill();
            p.BillDetails(custname, CId, unit);
        }
    }
}
