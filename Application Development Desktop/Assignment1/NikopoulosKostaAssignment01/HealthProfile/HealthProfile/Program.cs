using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class HealthProfile
    {
        private String firstName;
        private String lastName;
        private int birthYear;
        private double height;
        private double weight;
        private int currentYear;

        public HealthProfile(String firstName, String lastName, int birthYear, double height, double weight, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Height = height;
            Weight = weight;
            CurrentYear = currentYear;
        }

        public String FirstName
        {
            get
            {return firstName;}
            set
            { firstName = value; }
        }

        public String LastName
        {
            get
            {return lastName;}
            set
            {lastName = value;}
        }

        public int BirthYear
        {
            get
            {return birthYear;}
            set
            {birthYear = value;}
        }

        public double Height
        {
            get
            {return height;}
            set
            {height = value;}
        }

        public double Weight
        {
            get
            {return weight;}
            set
            {weight = value;}
        }

        public int CurrentYear
        {
            get
            {return currentYear;}
            set
            {currentYear = value;}
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
            get { return CalcMaxHeartRate / 2; }
        }

        public int CalcMaxTargetHeartRate
        {
          get{  return CalcMaxHeartRate * 85 / 100; }
        }

        public double BMI_Numerical_Value
        {
            get{return (weight * 703) / Math.Pow(height ,2);}
        }
        public String BMI_Text_Value(double weight, double height)
        {
            double bim = BMI_Numerical_Value;
            if (bim < 18.5)
                return "Underweigth";
            else if (bim >18.5 && bim < 24.9)
                return "Normal";
            else if (bim > 25 && bim < 29.9)
                return "Overweight";
            else if (bim >= 30)
                return "Obese";
            return BMI_Text_Value(weight,height);
        }

        public void DisplayHealthRecord()
        {
            Console.WriteLine("Problem‐02: Computerization of Health Records");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|                    PATIENT RECORDS                   |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"|{"Patient Name",25:D} | {LastName + ", " + FirstName,-25} |");
            Console.WriteLine($"|{"Patient Birth Year",25:D} | {BirthYear,25:D} |");
            Console.WriteLine($"|{"Patient Age",25:D} | {CalcAge,25} |");
            Console.WriteLine($"|{"Height",25} | {Height,25} |");
            Console.WriteLine($"|{"Weight",25} | {Weight,25} |");
            Console.WriteLine($"|{"Maximum Heart Rate",25:D} | {CalcMaxHeartRate,25} | ");
            Console.WriteLine($"|{"Target Heart Rate Range",25:D} | {CalcMinTargetHeartRate + "-" + CalcMaxTargetHeartRate,25} |");
            Console.WriteLine($"|{"BMI Numerical Value",25} | {BMI_Numerical_Value  ,25:F} |");
            Console.WriteLine($"|{"BMI Text Value",25} | { BMI_Text_Value(weight,height) ,-25} |");
            Console.WriteLine($"|------------------------------------------------------|");
            Console.WriteLine($"");
        }
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
            Console.WriteLine("How tall are you? :");
            double pheight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much do you weight? :");
            double pweight = Convert.ToDouble(Console.ReadLine());
            HealthProfile hp = new HealthProfile(fname, lname, byear, pheight, pweight, cyear);
            hp.DisplayHealthRecord();

        }
    }
}
