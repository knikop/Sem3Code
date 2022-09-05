using System;
using System.Windows.Forms;
using RestAPITest;
using static RestAPITest.employee;

namespace RestAPITest
{
    public partial class Form1 : Form
    {
        int i = 0;
        Datum[] data = getEmployeeData().data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            i--;
            if(i < 0)
            {
                i = data.Length - 1;
            }
            
            displayData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            if (i > data.Length - 1)
            {
                i = 0;
            }
            
            displayData();
        }
        public void displayData()
        {
            idTextBox.Text = data[i].id.ToString();
            nameTextBox.Text = data[i].employee_name;
            salaryTextBox.Text = String.Format("{0:C}" , data[i].employee_salary);
            ageTextBox.Text = data[i].employee_age.ToString();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0 : changeLanguage.UpdateConfig("language", "en");
                       Application.Restart();
                       break;
                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 3:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
            }
        }
    }
}
