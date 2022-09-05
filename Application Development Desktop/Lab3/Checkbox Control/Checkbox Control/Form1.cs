using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // toggle the font style between bold and 
        // not bold based on the current setting 
        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Bold);
        }

        // toggle the font style between italic and 
        // not italic based on the current setting 
        private void italicCheckBox_CheckedChanged(
        object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Italic);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}