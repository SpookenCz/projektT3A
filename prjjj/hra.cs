using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjjj
{
    public partial class hra : Form
    {
        string[] otazky = new string[]
        {
            "Kolik je 2 + 2?",
        };

        string[,] odpovedi = new string[,]
        {
            {"3","4","5","6"},
        };

        int[] spravna = new int[] {1};

        int aktualniOtazka = 0;




        private Form1 mainForm;

        public hra(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void hra_Load(object sender, EventArgs e)
        {
            NactiOtazku();
        }

        void NactiOtazku()
        {
            labelOtazka.Text = otazky[aktualniOtazka];
            buttonA.Text = odpovedi[aktualniOtazka, 0];
            buttonB.Text = odpovedi[aktualniOtazka, 1];
            buttonC.Text = odpovedi[aktualniOtazka, 2];
            buttonD.Text = odpovedi[aktualniOtazka, 3];
        }

        void ZkontrolujOdpoved(int index)
        {
            if (index == spravna[aktualniOtazka])
            {
                MessageBox.Show("Správně!");
                aktualniOtazka++;

                if (aktualniOtazka >= otazky.Length)
                {
                    MessageBox.Show("Vyhrál jsi!");
                    mainForm.Show();
                    this.Close();
                    return;
                }

                NactiOtazku();
            }
            else
            {
                MessageBox.Show("Špatně!");
                mainForm.Show();
                this.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Opravdu se chceš vrátit do hlavního menu?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vysledek == DialogResult.Yes)
            {
                mainForm.Show();
                this.Close();
            }
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            napoveda help = new napoveda();
            help.ShowDialog();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(0);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(2);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(3);
        }
    }
}
