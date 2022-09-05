using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupboxes_and_Panels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // event handler for Hi Button
         private void hiButton_Click(object sender, EventArgs e)
         {
            messageLabel.Text = "Hi pressed"; // change text in Label
         }
 
         // event handler for Bye Button
         private void byeButton_Click(object sender, EventArgs e)
         {
             messageLabel.Text = "Bye pressed"; // change text in Label
         }

         // event handler for Far Left Button
         private void leftButton_Click(object sender, EventArgs e)
         {
            messageLabel.Text = "Far Left pressed"; // change text in Label
         }

        // event handler for Far Right Button
        private void rightButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Right pressed"; // change text in Label
        }

       
    }
}
