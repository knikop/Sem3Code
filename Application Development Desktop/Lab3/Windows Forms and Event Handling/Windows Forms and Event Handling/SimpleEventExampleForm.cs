using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_and_Event_Handling
{
    public partial class SimpleEventExampleForm : Form
    {
        public SimpleEventExampleForm()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void SimpleEventExampleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
