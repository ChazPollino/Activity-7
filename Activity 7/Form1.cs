using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Activity7 : Form
    {
        public Activity7()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "") 
            {
                MessageBox.Show("Please enter the terms");
            }
            else
            {
                double PI; 
                int i, x; 
                int terms; 
                terms = Convert.ToInt32(UserTextbox.Text);
                
                PI = 0;
                x = 1;
                
                for (i = 1; i <= terms; i++) 
                {
                    PI = PI + 4 * Math.Pow(-1, (i - 1)) / x;
                    x = x + 2;
                } 

                AnswerLabel.Text = "Answer = " + PI;





            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserTextbox.Text = "";

            AnswerLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}