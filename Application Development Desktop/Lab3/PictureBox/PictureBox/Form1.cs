using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class PictureBoxTest : Form
    {
        private int ImageNumber { get; set; } = -1; // image to display
        public PictureBoxTest()
        {
            InitializeComponent();
        }

        // change image whenever Next Button is clicked
         private void nextButton_Click(object sender, EventArgs e)
         {
         ImageNumber = (ImageNumber + 1) % 3; // cycles from 0 to 2
 
         // retrieve image from resources and load into PictureBox
         imagePictureBox.Image = 
         (Image) (Properties.Resources.ResourceManager.GetObject(
         $"image{ImageNumber}")); 
         }
    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
