using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class NumericUpDownTest : Form
    {
        public NumericUpDownTest()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
         {
         // retrieve user input
         decimal principal = decimal.Parse(principalTextBox.Text);
         double rate = double.Parse(interestTextBox.Text);
         int year = (int)yearUpDown.Value;
 
         // set output header
         string output = "Year\tAmount on Deposit\r\n";
 
         // calculate amount after each year and append to output
         for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
         {
         decimal amount = principal *
        ((decimal)Math.Pow((1 + rate / 100), yearCounter));
         output += $"{yearCounter}\t{amount:C}\r\n";
         } 
 
         displayTextBox.Text = output; // display result
         }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
