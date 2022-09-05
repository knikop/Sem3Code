using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugeInteger
{
    public partial class HugeIntegerCalculator : Form
    {
        private HugeInteger int1 = new HugeInteger();
        private HugeInteger int2 = new HugeInteger();

        public HugeIntegerCalculator()
        {
            InitializeComponent();
        }

        private void firstNum_TextChanged(object sender, EventArgs e)
        {
            int1.Input(firstNumTextBox.Text);
            updateDisplay();
        }

        private void secondNum_TextChanged(object sender, EventArgs e)
        {
            int2.Input(secondNumTextBox.Text);
            updateDisplay();
        }

        private void updateDisplay()
        {
            switch (choices.SelectedIndex)
            {
                case 0:
                    answerLabel.Text = int1.Multiply(int2).ToString();
                    break;
                case 1:
                    answerLabel.Text = int1.Divide(int2);
                    break;
                case 2:
                    answerLabel.Text = int1.Remainder(int2);
                    break;
                case 3:
                    answerLabel.Text = int1.Add(int2);
                    break;
                case 4:
                    answerLabel.Text = int1.Substract(int2);
                    break;
                case 5:
                    answerLabel.Text = int1.IsZero().ToString();
                    break;
                case 6:
                    answerLabel.Text = int1.IsEqualTo(int2).ToString();
                    break;
                case 7:
                    answerLabel.Text = int1.IsNotEqualTo(int2).ToString();
                    break;
                case 8:
                    answerLabel.Text = int1.IsGreaterThan(int2).ToString();
                    break;
                case 9:
                    answerLabel.Text = int1.IsLessThan(int2).ToString();
                    break;
                case 10:
                    answerLabel.Text = int1.IsGreaterThanOrEqualTo(int2).ToString();
                    break;
                case 11:
                    answerLabel.Text = int1.IsLessThanOrEqualTo(int2).ToString();
                    break;
            }
        }

        private void choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
