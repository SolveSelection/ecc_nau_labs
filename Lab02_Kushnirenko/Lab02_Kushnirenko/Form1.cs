using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Kushnirenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numSys = 0;
        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            string strKey = textBox_Key.Text;
            if (numSys == 2 && Convert.ToInt32(strP) >1 && Convert.ToInt32(strKey) > 1) 
            { MessageBox.Show("Помилка! " +
                "Цифра у двійковому коді не може бути більшою за одиницю"); }
            else {
                int intP = Convert.ToInt32(strP, numSys);
                int intKey = Convert.ToInt32(strKey, numSys);

                int intC = intP ^ intKey;
                string strC = Convert.ToString(intC, numSys);
                textBox_C.Text = strC;

                //P
                label_PH.Text = Convert.ToString(intP, 16).ToUpper() + "H";
                label_PD.Text = Convert.ToString(intP, 10) + "D";
                label_PB.Text = Convert.ToString(intP, 2) + "B";
                //Key
                label_KeyH.Text = Convert.ToString(intKey, 16).ToUpper() + "H";
                label_KeyD.Text = Convert.ToString(intKey, 10) + "D";
                label_KeyB.Text = Convert.ToString(intKey, 2) + "B";
                //C
                label_CH.Text = strC + "H";
                label_CD.Text = Convert.ToString(intC, 10).ToUpper() + "D";
                label_CB.Text = Convert.ToString(intC, 2) + "B";
            }
            
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
        }

        private void radioButton_Hex_CheckedChanged(object sender, EventArgs e)
        {
            numSys = 16;
            button_XOR.Enabled = true;
        }

        private void radioButton_Dec_CheckedChanged(object sender, EventArgs e)
        {
            numSys = 10;
            button_XOR.Enabled = true;
        }

        private void radioButton_Bin_CheckedChanged(object sender, EventArgs e)
        {
            numSys = 2;
            button_XOR.Enabled = true;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (radioButton_Bin.Checked)
            {
                button_XOR.Enabled = true;
                if (c == '0' || c == '1' || char.IsControl(c) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = false;
                }
                numSys = 2;
            }
            else if (radioButton_Hex.Checked)
            {
                button_XOR.Enabled = true;
                if (c == '0' ||
                    c == '1' ||
                    c == '2' ||
                    c == '3' ||
                    c == '4' ||
                    c == '5' ||
                    c == '6' ||
                    c == '7' ||
                    c == '8' ||
                    c == '9' ||

                    c == 'a' ||
                    c == 'b' ||
                    c == 'c' ||
                    c == 'd' ||
                    c == 'e' ||
                    c == 'f' ||
                    char.IsControl(c) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = false;
                }
                numSys = 16;
            }
            else if (radioButton_Dec.Checked)
            {
                button_XOR.Enabled = true;
                if (c == '0' ||
                    c == '1' ||
                    c == '2' ||
                    c == '3' ||
                    c == '4' ||
                    c == '5' ||
                    c == '6' ||
                    c == '7' ||
                    c == '8' ||
                    c == '9' ||
                    char.IsControl(c) == true)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = false;
                }
                numSys = 10;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
