using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SecurityQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //DateTime now = DateTime.Now;
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Display.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_Display.Text += "2";
        }

        private void txt_Display_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_Display.Text += "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_Display.Text += "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_Display.Text += "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "8";
        }

        private void btn_ninth_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + "0";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
            DateTime now = DateTime.Now;
            string dateString = now.ToString("ddMMyyyyHHmmss");
           
            //int num = Int32.Parse(txt_Display.Text);
            if (Int32.Parse(txt_Display.Text) >= 1645 && Int32.Parse(txt_Display.Text) <= 4689)
            {
                txt_Display.BackColor = Color.Gray;
                rtb_LogEntry.BackColor = Color.Gray;
                rtb_LogEntry.Text += "\n" + now.ToString() + "  Access Granted!";
                rtb_LogEntry.Text += "\n" + now.ToString() + "  The Technicains";

            }
            else if (Int32.Parse(txt_Display.Text) == 8345)
            {
                txt_Display.BackColor = Color.Gray;
                rtb_LogEntry.BackColor = Color.Gray;
                rtb_LogEntry.Text += "\n" + now.ToString() + "  Access Granted!";
                rtb_LogEntry.Text += "\n" + now.ToString() + "   The Cleaners";


            }
            else if (txt_Display.Text == "999898")
            {
                txt_Display.BackColor = Color.Gray;
                rtb_LogEntry.BackColor = Color.Gray;
                rtb_LogEntry.Text += "\n" + now.ToString() + "  Access Granted!";
                rtb_LogEntry.Text += "\n" + now.ToString() + "   A Chief Scientist";

            }
            else if (Int32.Parse(txt_Display.Text) >= 1000006 && Int32.Parse(txt_Display.Text) == 1000008)
            {
                txt_Display.BackColor = Color.Gray;
                rtb_LogEntry.BackColor = Color.Gray;
                rtb_LogEntry.Text += "\n" + now.ToString() + "  Access Granted!";
                rtb_LogEntry.Text += "\n" + now.ToString() + "   A Scientist";
            }

            else
            {
                rtb_LogEntry.Text += "\n" + now.ToString() + "  Access Denied!";

                txt_Display.BackColor = Color.Red;
                rtb_LogEntry.BackColor = Color.Red;
            }



            txt_Display.Clear();
         }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Display.Clear();
        }

        private void rtb_LogEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
