﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the first button.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the second button.");
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the third button.");
        }
    }
}