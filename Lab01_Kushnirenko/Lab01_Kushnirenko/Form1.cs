using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Kushnirenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {

                if (textBox_login.Text == "Yuriy" && textBox_Password.Text == "123")
                {
                    label_ok.BackColor = Color.Green;
                    label_ok.Text = "ok";
                    MessageBox.Show("Hello, Yuriy");
                }
                else
                {
                    label_ok.Text = "wrong";
                    label_ok.BackColor = Color.Red;
                    
                    MessageBox.Show("Error login or password");
                    counter++;
                }
            }
            if(counter >= 3) { button1.Enabled = false; }
            label3.Text = (3 - counter).ToString();
            
        }
    }
}
