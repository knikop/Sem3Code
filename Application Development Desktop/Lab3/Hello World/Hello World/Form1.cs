using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class button : Form
    {
        public button()
        {
            InitializeComponent();
        }

        private void messageButton_Load(object sender, EventArgs e)
        {

        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
