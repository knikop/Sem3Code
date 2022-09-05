using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Inheritance_Hierarchy
{
    class Person
    {
        private string lastName;
        private string firstName;
        private string address;
        private string phone;

        public Person(String lastName, String firstName, String address, String phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public virtual void DisplayData()
        {
            Console.WriteLine("");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|                        PERSON                        |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|{"Last Name: ",25 } | {LastName,-25} |");
            Console.WriteLine($"|{"First Name: ",25 } | {FirstName,-25} |");
            Console.WriteLine($"|{"Address: ",25 } | {Address,-25} |");
            Console.WriteLine($"|{"Phone Number: ",25 } | {Phone,25} |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"");



        }
    }
}
