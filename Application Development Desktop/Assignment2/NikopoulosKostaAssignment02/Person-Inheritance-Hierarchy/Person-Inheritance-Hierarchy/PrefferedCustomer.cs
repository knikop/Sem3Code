using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Inheritance_Hierarchy
{
    class PreferredCustomer : Customer
    {
        private decimal purchaseAmount;
        private int discountLevel;

        public PreferredCustomer(string firstName, string lastName, string address, string phone, int customerNumber, bool mailingList, decimal purchaseAmount)
            : base(firstName, lastName, address, phone, customerNumber, mailingList)
        {
            PurchaseAmount = purchaseAmount;
            DiscountLevel = discountLevel;
        }
        public decimal PurchaseAmount
        {
            get { return purchaseAmount; }
            set
            {
                if (purchaseAmount < 0)
                {
                    purchaseAmount = 0;
                    Console.WriteLine("Customer purchases amount should be a positive value.");
                }
                else
                {
                    purchaseAmount = value;
                }
            }
        }
        public int DiscountLevel
        {
            get { return discountLevel; }
            set
            {
                if (purchaseAmount >= 500 && purchaseAmount < 1000)
                    discountLevel = 5;
                else if (purchaseAmount >= 1000 && purchaseAmount < 1500)
                    discountLevel = 6;
                else if (purchaseAmount >= 1500 && purchaseAmount < 2000)
                    discountLevel = 7;
                else if (purchaseAmount >= 2000)
                    discountLevel = 10;
            }
        }

        public override void DisplayData()
        {

            Console.WriteLine("");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|                 PREFERRED CUSTOMER                   |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|{"Customer Number: ",25} | { CustomerNumber,25} |");
            Console.WriteLine($"|{"Last Name: ",25 } | {LastName,-25} |");
            Console.WriteLine($"|{"First Name: ",25 } | {FirstName,-25} |");
            Console.WriteLine($"|{"Address: ",25 } | {Address,-25} |");
            Console.WriteLine($"|{"Phone Number: ",25 } | {Phone,25} |");
            Console.WriteLine($"|{"MailingList List: ",25 } | {(MailingList == true? "Yes": "NO"),-25} |");
            Console.WriteLine($"|{"Purchase Amount: ",25 } | { purchaseAmount,25:C} |");
            Console.WriteLine($"|{"Discount Level: ",25 } | { (double)discountLevel/100,25:P} |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"");
        }

    }
}
