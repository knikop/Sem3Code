using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Inheritance_Hierarchy
{    
    class Driver
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("What is your last name? :");
            String lname = Console.ReadLine();
            Console.WriteLine("What is your first name? :");
            String fname = Console.ReadLine();
            Console.WriteLine("Your Address: ");
            String ads = Console.ReadLine();
            Console.WriteLine("What is your phone number? :");
            String phnum = Console.ReadLine();
            Person p = new Person(lname, fname, ads, phnum);
            p.DisplayData();

            Console.WriteLine("Whats the customer number? :");
            int customerNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wanna be on the list?(Y or N) :");
            bool mList = false;
            string ans = Console.ReadLine();
            if (ans.Equals('Y')||ans.Equals('y'))
            {
                mList = true;
            }
            else
            {
                mList = false;
            }
            Customer c = new Customer(fname, lname, ads, phnum, customerNum, mList);
            c.DisplayData();

            Console.WriteLine("How much did you spend?");
            decimal pAmount = Convert.ToDecimal(Console.ReadLine());
            PreferredCustomer pc = new PreferredCustomer(fname, lname, ads, phnum, customerNum, mList, pAmount);
            pc.DisplayData();

        }
    }
}
