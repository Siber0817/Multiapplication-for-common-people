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
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            { 
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            label1.Text = Convert.ToString(timer1.Interval);
            while (timer1.Interval > 600)
                label2.Text = "Nádech";
            while (timer1.Interval > 300)
                label2.Text = "Drž";
            while (timer1.Interval < 300)
                label2.Text = "Výdech";
        }
    }
}
