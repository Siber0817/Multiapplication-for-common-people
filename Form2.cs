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
    public partial class Form2 : Form
    {
        int kofein = 0;
        int kafe = 0;
        int tea = 0;
        int weight = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kafe = Convert.ToInt32(textBox1.Text);
            int tea = Convert.ToInt32(textBox2.Text);
            int weight = Convert.ToInt32(textBox3.Text);
            if(checkBox1.Checked == true)
            {
                kofein = (kafe * 2 * 90) + (tea * 50);
                if(kofein > weight * 3)
                {
                    MessageBox.Show("Váš aktuální příjem kofeinu je " + kofein + "mg. Váš bezpečný denní příjem je " + weight * 3 + "mg. Tuto hodnotu jste přesáhly a doporučuji přestat xD");
                }
                else
                {
                    MessageBox.Show("Váš aktuální příjem kofeinu je " + kofein + "mg. Váš bezpečný denní příjem je " + weight * 3 + "mg. Zatím jste v pořádku :).");
                }
            }
            else
            {
                kofein = (kafe * 90) + (tea * 50);
                if (kofein > weight * 3)
                {
                    MessageBox.Show("Váš aktuální příjem kofeinu je " + kofein + "mg. Váš bezpečný denní příjem je " + weight * 3 + "mg. Tuto hodnotu jste přesáhly a doporučuji přestat xD");
                }
                else
                {
                    MessageBox.Show("Váš aktuální příjem kofeinu je " + kofein + "mg. Váš bezpečný denní příjem je " + weight * 3 + "mg. Zatím jste v pořádku :).");
                }
            }
        }
    }
}
