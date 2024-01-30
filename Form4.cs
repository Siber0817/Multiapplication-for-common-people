using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApka
{
    public partial class Form4 : Form
    {
        int seconds = 0;
        int change = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 3;
            change = 9;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (change >= 7)
            {
                label2.Text = "Nádech";
                change= change-1;
            }
            else if (change >= 4)
            {
                label2.Text = "Drž";
                change= change-1;
            }
            else if (change >= 1)
            {
                label2.Text = "Výdech";
                change = change - 1;
            }
            else if (change == 0)
            {
                change = 9;
            }
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            label1.Text = seconds.ToString();
            seconds = seconds - 1;
            if ( seconds == 0 )
            {
                seconds = 3;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
