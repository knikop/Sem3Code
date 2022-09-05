﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        private object okRadioButton;

        // create variables that store the user's choice of options
        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // change Buttons based on option chosen by sender
        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okRadioButton) // display OK Button
            {
                ButtonType = MessageBoxButtons.OK;
            }
            // display OK and Cancel Buttons
            else if (sender == okCancelRadioButton)
            {
                ButtonType = MessageBoxButtons.OKCancel;
            }
            // display Abort, Retry and Ignore Buttons
            else if (sender == abortRetryIgnoreRadioButton)
            {
                ButtonType = MessageBoxButtons.AbortRetryIgnore;
            }
            // display Yes, No and Cancel Buttons
            else if (sender == yesNoCancelRadioButton)
            {
                ButtonType = MessageBoxButtons.YesNoCancel;
            }
            // display Yes and No Buttons
            else if (sender == yesNoRadioButton)
            {
                ButtonType = MessageBoxButtons.YesNo;
            }
            // only one option left--display Retry and Cancel Buttons
            else
            {
                ButtonType = MessageBoxButtons.RetryCancel;
            }
        }

        // change Icon based on option chosen by sender
        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton) // display asterisk Icon
            {
                IconType = MessageBoxIcon.Asterisk;
            }
            // display error Icon
            else if (sender == errorRadioButton)
            {
                IconType = MessageBoxIcon.Error;
            }
            // display exclamation point Icon
            else if (sender == exclamationRadioButton)
            {
                IconType = MessageBoxIcon.Exclamation;
            }
            // display hand Icon
            else if (sender == handRadioButton)
            {
                IconType = MessageBoxIcon.Hand;
            }

            // display information Icon
            else if (sender == informationRadioButton)
            {
                IconType = MessageBoxIcon.Information;
            }
            // display question mark Icon
            else if (sender == questionRadioButton)
            {
                IconType = MessageBoxIcon.Question;
            }
            // display stop Icon
            else if (sender == stopRadioButton)
            {
                IconType = MessageBoxIcon.Stop;
            }
            // only one option left--display warning Icon
            else
            {
                IconType = MessageBoxIcon.Warning;
            }
        }
        // display MessageBox and Button user pressed
        private void displayButton_Click(object sender, EventArgs e)
        {
            // display MessageBox and store 
            // the value of the Button that was pressed 
            DialogResult result = MessageBox.Show(
            "This is your Custom MessageBox.", "Custon MessageBox",
            ButtonType, IconType);
            // check to see which Button was pressed in the MessageBox
            // change text displayed accordingly
            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed.";
                    break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
