using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Inheritance_Hierarchy
{
    class Customer : Person
    {
        private int customerNumber;
        private bool mailingList;

        public Customer(string firstName, string lastName, string address, string phone, int customerNumber, bool mailingList)
            : base(firstName, lastName, address, phone)
        {
            CustomerNumber = customerNumber;
            MailingList = mailingList;
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (customerNumber > 0)
                { customerNumber = value; }
                else
                {
                    customerNumber = 99999;
                    Console.WriteLine($"Customer number should be a positive Integer value. ");
                }
            }
        }
        public bool MailingList
        {
            get { return mailingList; }
            set { mailingList = value; }
        }
        public override void DisplayData()
        {
            String YesOrNO;
            if (mailingList == true)
                YesOrNO = "yes";
            else
                YesOrNO = "no";

            Console.WriteLine("");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|                        CUSTOMER                      |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|{"Customer Number: ",25} | { customerNumber,25} |");
            Console.WriteLine($"|{"Last Name: ",25 } | {LastName,-25} |");
            Console.WriteLine($"|{"First Name: ",25 } | {FirstName,-25} |");
            Console.WriteLine($"|{"Address: ",25 } | {Address,-25} |");
            Console.WriteLine($"|{"Phone Number: ",25 } | {Phone,25} |");
            Console.WriteLine($"|{"Mailing List: ",25} | {YesOrNO,-25} |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"");
        }
    }
}
