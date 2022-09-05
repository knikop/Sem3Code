using System;
using System.Collections.Generic;
using System.Text;

namespace HugeInteger
{
    class HugeInteger
    {
        private char[] digits { get; set; }
        public HugeInteger()
        {
            digits = new char[40];
        }
       
        public void Input(String num)
        {
            if (num.Length > 40)
                return;
            foreach (char c in num)
            {
                if (c < '0' || c > '9')
                    return;
            }
           
            digits = num.ToCharArray();
            return;
        }

        public override string ToString()
        {
            String result = string.Join("", digits);
            return result;
        }

        public String Multiply(HugeInteger obj)
        {
            String num1 = obj.ToString();
            String num2 = this.ToString();

            int len1 = num1.Length;
            int len2 = num2.Length;
            if (len1 == 0 || len2 == 0)
                return "0";
            //will keep the result in reverse order
            int[] result = new int[len1 + len2];
            //indexs to find positions in result
            int i_n1 = 0;
            int i_n2 = 0;
            int i;

            //Going from the right to left in num1
            for(i= len1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int n1 = num1[i] - '0';
                //Shifts position to the left after every multiplication of a digit in num2
                i_n2 = 0;
                //Going from the right to left in num2
                for(int j = len2 - 1; j >= 0; j--)
                {   //using the current digit of the second num
                    int n2 = num2[j] - '0';
                    //Multiply with the current digit of first number and add the result to previous store result
                    int sum = n1 * n2 + result[i_n1 + i_n2] + carry;
                    //Carry to next step
                    carry = sum / 10;
                    //store the result
                    result[i_n1 + i_n2] = sum % 10;

                    i_n2++;
                }
                //storing the carry
                if (carry > 0)
                    result[i_n1 + i_n2] += carry;
                //Shifts position to the left after every multiplication of a digit in num1
                i_n1++;
            }
            //ignore the '0's from the right
            i = result.Length - 1;
            while (i >= 0 && result[i] == 0)
                i--;
            //If all are '0's either means that both or one of num1 or num2 were '0'
            if (i == -1)
                return "0";
            //Generate result string
            String s = "";
            while (i >= 0)
                s += (result[i--]);
            return s;
           
        }

        public String Divide(HugeInteger obj)
        {
            String res = "";
            HugeInteger topNum = new HugeInteger();
            HugeInteger bottomNum = new HugeInteger();
            topNum.Input(this.ToString());
            bottomNum.Input(obj.ToString());
            int count = 0;
            if (topNum.IsZero() || bottomNum.IsZero())
            {
                return "0";
            }
            for (int i = 40 - 1; i >= 0; i--)
            {
                while (topNum.IsGreaterThanOrEqualTo(bottomNum))
                {
                    topNum.Input(topNum.Substract(bottomNum));
                    count++;
                }
                res += count;
            }
            return res;
        }

        public String Remainder(HugeInteger obj)
        {
            String res = "";
            HugeInteger topNum = new HugeInteger();
            HugeInteger bottomNum = new HugeInteger();
            topNum.Input(this.ToString());
            bottomNum.Input(obj.ToString());
            
            while (topNum.IsGreaterThanOrEqualTo(bottomNum))
                {
                    topNum.Input(topNum.Substract(bottomNum));
                }
            res = topNum.ToString();
            return res;
        }

        public String Add(HugeInteger obj)
        {
            String str1 = obj.ToString();
            String str2 = this.ToString();
            if (str1.Length > str2.Length)
            {
                String t = str1;
                str1 = str2;
                str2 = t;
            }
            String str = "";
            //Calculate the length of both strings
            int n1 = str1.Length, n2 = str2.Length;
            //Reverse both the strings
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < n1; i++)
            {   //calculate the sum of the current digits and carry
                int sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                //Calculate the carry for the next step
                carry = sum / 10;
            }
            //Add remaining digits
            //for(int i = n1; i < n2; i++)
            //{   
            //    int sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry);
            //    str += (char)(sum % 10 + '0');
            //    carry = sum / 10;
            //}
            ////Add the remaining carry
            //if (carry > 0)
            //    str += (char)(carry + '0');
            ////Reverse the string
            char[] ch2 = new char[40];
            ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);
            //str = "333";
            return str;
           
        }
        //Will return true if string 1(str1) is smaller than string 2(str2)
        //Helps in the susbtract method
        static bool isSmaller(string str1, string str2)
        {
            int n1 = 0;
            for (int i = 0; i < n1; i++)
            if (str1[i] < str2[i])
                return true;
            else if (str1[i] > str2[i])
                return false;
            return false;
        }

        public String Substract(HugeInteger obj)
        {
            String str1 = obj.ToString();
            String str2 = this.ToString();
            if (isSmaller(str1,str2))
            {
                String t = str1;
                str1 = str2;
                str2 = t;
            }
            String str = "";
            //Calculate length of both strings
            int n1 = str1.Length, n2 = str2.Length;
            //Reverse both strings
            char[] ch1 = str1.ToCharArray();
            Array.Reverse(ch1);
            str1 = new string(ch1);
            char[] ch2 = str2.ToCharArray();
            Array.Reverse(ch2);
            str2 = new string(ch2);

            int carry = 0;
            //Run loop and substract digits of str1 to str2
            for(int i =0; i < n2; i++)
            {   //calculate the diff of the current digits
                int sub = ((int)(str1[i] - '0') - (int)(str2[i] - '0') - carry);
                //If substraction = <0, add then add 10 into sub and carry
                if (sub < 0)
                {   //calculate diff of current digits
                    sub = sub + 10;
                    carry = 1;
                }
                else
                    carry = 0;
                str += (char)(sub + '0');
            }
            //substract remaining digits
            for(int i = n2; i < n1; i++)
            {
                int sub = ((int)(str1[i] - '0') - carry);
                //if sub value is negative
                //make positive
                if (sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                    carry = 0;
                str += (char)(sub + '0');
            }
            //Reverse the string
            char[] ch3 = str.ToCharArray();
            Array.Reverse(ch3);
            return new string(ch3);
        }

        public bool IsZero()
        {
            String str = digits.ToString();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0')
                    return false;
            }
            return true;
        }

        public bool IsEqualTo(HugeInteger obj)
        {
            String str1 = obj.ToString();
            String str2 = this.ToString();

            return str1.Equals(str2);
        }

        public bool IsNotEqualTo(HugeInteger obj)
        {
            return !IsEqualTo(obj);
        }

        public bool IsGreaterThan(HugeInteger obj)
        {
            String str1 = this.ToString();
            String str2 = obj.ToString();
            if (str1.Length > str2.Length)
                return true;
            else if (str1.Length < str2.Length)
                return false;
            int cha = 0;
            while(cha < str1.Length)
            {
                if (Convert.ToInt32(str1[cha]) > Convert.ToInt32(str2[cha]))
                    return true;
                cha++;
            }
            return false;
        }

        public bool IsLessThan(HugeInteger obj)
        {
            if (IsEqualTo(obj) || IsGreaterThan(obj))
                return false;
            return true;
        }

        public bool IsGreaterThanOrEqualTo(HugeInteger obj)
        {
            if (IsEqualTo(obj) || IsGreaterThan(obj))
                return true;
            return false;
        }

        public bool IsLessThanOrEqualTo(HugeInteger obj)
        {
            if (IsLessThan(obj) || IsEqualTo(obj))
                return true;
            return false;
        }
    }
}