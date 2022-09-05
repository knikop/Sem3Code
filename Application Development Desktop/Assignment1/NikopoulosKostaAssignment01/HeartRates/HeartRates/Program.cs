using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    class HeartRates
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;

        public HeartRates(String firstName, String lastName, int birthYear, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = currentYear;
        }
        public String FirstName
        {
            get
            { return firstName; }
            set
            {firstName = value; }
        }
        public String LastName
        {
            get
            { return lastName; }
            set
            { lastName = value; }
        }

        public int BirthYear
        {
            get
            { return birthYear; }
            set
            { birthYear = value; }
        }

        public int CurrentYear
        {
            get
            { return currentYear; }
            set
            { currentYear = value; }
        }
        public int CalcAge
        {
            get { return CurrentYear - BirthYear; }
        }

        public int CalcMaxHeartRate
        {
            get { return 220 - CalcAge; }
        }

        public int CalcMinTargetHeartRate
        {
            get { return (CalcMaxHeartRate / 2); }
        }

        public int CalcMaxTargetHeartRate
        {
            get { return CalcMaxHeartRate * 85 / 100; }
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("Problem‐01: Target‐Heart‐Rate Calculator");
            Console.WriteLine($"|---------------------------------------------------------------------|");
            Console.WriteLine($"|                             PATIENT RECORDS                         |");
            Console.WriteLine($"|---------------------------------------------------------------------|");
            Console.WriteLine($"|{"Patient Name",25:D} | {LastName + ", " + FirstName,-40} |");
            Console.WriteLine($"|{"Patient Birth Year",25:D} | {BirthYear,40:D} |");
            Console.WriteLine($"|{"Patient Age",25:D} | {CalcAge,40} |");
            Console.WriteLine($"|{"Maximum Heart Rate",25:D} | {CalcMaxHeartRate,40:.} | ");
            Console.WriteLine($"|{"Target Heart Rate Range",25:D} | {CalcMinTargetHeartRate + "-" + CalcMaxTargetHeartRate,40:.} |");
            Console.WriteLine($"|---------------------------------------------------------------------|");
            Console.WriteLine($"");

        }
        class Driver
        {
            static void Main(string[] args)
            {
                Console.WriteLine("What is your first name? :");
                String fname = Console.ReadLine();
                Console.WriteLine("What is your last name? :");
                String lname = Console.ReadLine();
                Console.WriteLine("In what year were you born? :");
                int byear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What year is it now? :");
                int cyear = Convert.ToInt32(Console.ReadLine());
                HeartRates h = new HeartRates(fname, lname, byear, cyear);
                h.DisplayPatientRecord();
            }
        }
    }
}
