using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiApka
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.reddit.com/r/dankmemes/";
            myProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.reddit.com/r/motivation/";
            myProcess.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.reddit.com/r/linuxmemes/";
            myProcess.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, 10);

            if (rInt == 0)
            {
                MessageBox.Show("Na cestě k úspěchu je mnoho překážek. Proto se snaž, aby jsi se nestal/a jednou z nich.");
            }
            else if (rInt == 1)
            {
                MessageBox.Show("Dokud nezměníme stav své mysli, budeme znovu a znovu vytvářet v podstatě stejný svět, se stejnými démony a stejně šílený.");
            }
            else if (rInt == 2)
            {
                MessageBox.Show("Pokud si nebuduješ svůj vlastní sen, buduješ sen někoho jiného.");
            }
            else if (rInt == 3)
            {
                MessageBox.Show("Zázraky se stávají lidem, kteří na ně věří. Nikdy na ně nepřestaň věřit");
            }
            else if (rInt == 4)
            {
                MessageBox.Show("Ten, kdo padne a znovu vstane, je mnohem silnější než ten, kdo nikdy nespadnul.");
            }
            else if (rInt == 5)
            {
                MessageBox.Show("To, že se usmívám neznamená, že je všechno pořád podle mých představ. Úsměv je symbolem mé síly a naděje.");
            }
            else if (rInt == 6)
            {
                MessageBox.Show("Nejdůležitější krok je ten první.");
            }
            else if (rInt == 7)
            {
                MessageBox.Show("Nemůžete změnit svůj život, dokud nezměníte něco, co děláte každý den. Úspěch je o malých krocích.");
            }
            else if (rInt == 8)
            {
                MessageBox.Show("Život není o tom čekat, až bouřka přejde, je dobré naučit se tančit v dešti.");
            }
            else if (rInt == 9)
            {
                MessageBox.Show("Nikdy nevzdávej své sny jen kvůli názoru jiných.");
            }
            else if (rInt == 10)
            {
                MessageBox.Show("Neúspěch nastane pouze ve chvíli, kdy se vzdáš. Vždy můžeš zkusit ještě něco udělat znovu jinak, objevit novou cestu.");
            }
        }
    }
}
