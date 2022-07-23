using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Show();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            button1.Enabled = false;
            if (sayac == 30)
            {
                pictureBox2.Show();
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                this.BackColor = Color.Red;
            }
            if (sayac == 40)
            {
                pictureBox3.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                this.BackColor = Color.Yellow;
            }
            if (sayac == 70)
            {
                pictureBox4.Show();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                this.BackColor = Color.Green;
                sayac = 0;
            }
        }
    }
}
