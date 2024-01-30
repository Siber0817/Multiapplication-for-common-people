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
            seconds = 4;
            change = 11;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (change >= 8)
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
                
                change = 11;
            }
           
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            seconds = seconds - 1;
            progressBar1.Value += 10;
            label1.Text = seconds.ToString();
            
            
            if ( seconds == 0 )
            {
                seconds = 4;
                progressBar1.Value = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
