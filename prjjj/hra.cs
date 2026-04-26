using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace prjjj
{
    public partial class hra : Form
    {
        string[] otazkyLehke = { "Kolik je 2 + 2?", "Který sport nepoužívá míč", "Jaký je chemický symbol pro kyslík?", "Jaký strom má žaludy?", "Jaké je skupenství vody při 0 °C a níž?" };
        string[,] odpovediLehke =
        {
             {"3","4","5","6"}, {"Fotbal","Basketbal","Hokej","Volejbal"}, {"S","H","Hg","O"}, {"Dub","Buk","Borovice","Lípa"}, {"Plynné","Kapalné","Pevné","Žádné"},
        };
        int[] spravnaLehke = { 1, 2, 3, 0, 2 };

        string[] otazkyStredni = { "Kolik je 5 * 5?", "Kolik hráčů má jeden fotbalový tým na hřišti?", "Kdo složil slavnou „9. symfonii“?", "Který oceán leží mezi Amerikou a Evropou?", "Jaká měna se používá v Japonsku?", };
        string[,] odpovediStredni =
        {
            {"10","20","25","30"}, {"9","10","11","12"}, {"Mozart","Beethoven","Mach","Chopin"}, {"Severní ledový","Tichý","Indický","Atlantský"}, {"Jen","Won","Chuan","Dollar"},
        };
        int[] spravnaStredni = { 2, 2, 1, 3, 0 };

        string[] otazkyTezke = { "Kolik je 12 * 12?", "Jaký vynález je spojen s bratry Wrightovými?", "Jaký je hlavní prvek v jádru hvězd?", "Kdo byl poslední panovník Ruska před revolucí v roce 1917?", "Který chemik vyvinul periodickou tabulku prvků?", };
        string[,] odpovediTezke =
        {
            {"100","144","120","130"}, {"Letadlo","Auto","Rádio","Motocykl"}, {"Helium","Kyslík","Vodík","Uhlík"}, {"Ivan Hrozný","Petr Veliký","Alexandra I.","Mikuláš II."}, {"Mendělejev","Einstein","Curie","Lavoisier"},
        };
        int[] spravnaTezke = { 1, 0, 2, 3, 0 };

        int aktualniOtazka = 0;
        int obtiznost = 0; // 0 = lehká, 1 = střední, 2 = těžká
        int pocetSpravnych = 1;
        int[] penize = { 1000, 2000, 3000, 4000, 5000, 10000, 20000, 50000, 75000, 100000, 250000, 500000, 690420, 750000, 1000000 };
        bool[] pouzite;
        Random rnd = new Random();
        int posun = 0;


        private Form1 mainForm;

        public hra(Form1 form)
        {
            InitializeComponent();
            mainForm = form;

        }

        private void hra_Load(object sender, EventArgs e)
        {
            InicializujPouzite();
            NactiOtazku();
            label1.Text = penize[0].ToString() + " Kč";
            label2.Text = penize[1].ToString() + " Kč";
            label3.Text = penize[2].ToString() + " Kč";
            label4.Text = penize[3].ToString() + " Kč";
            label5.Text = penize[4].ToString() + " Kč";
            label1.BackColor = Color.DarkOrange;
        }

        void NactiOtazku()
        {
            aktualniOtazka = VyberNahodnouOtazku();

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            if (obtiznost == 0)
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyLehke[aktualniOtazka];
                buttonA.Text = "A: " + odpovediLehke[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediLehke[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediLehke[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediLehke[aktualniOtazka, 3];
            }
            else if (obtiznost == 1)
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyStredni[aktualniOtazka];
                buttonA.Text = "A: " + odpovediStredni[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediStredni[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediStredni[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediStredni[aktualniOtazka, 3];
            }
            else
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyTezke[aktualniOtazka];
                buttonA.Text = "A: " + odpovediTezke[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediTezke[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediTezke[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediTezke[aktualniOtazka, 3];
            }
        }

        void ZkontrolujOdpoved(int index)
        {
            if (index == spravnaAktualni())
            {
                MessageBox.Show("Správně!");
                pocetSpravnych++;
                if (pocetSpravnych == 14)
                {
                    posun++;
                }
                if (posun == 0)
                {
                    label1.BackColor = Color.DarkGreen;
                    label2.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 1)
                {
                    label2.BackColor = Color.DarkGreen;
                    label3.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 2)
                {
                    label1.Text = penize[pocetSpravnych - 3].ToString() + " Kč";
                    label2.Text = penize[pocetSpravnych - 2].ToString() + " Kč";
                    label3.Text = penize[pocetSpravnych - 1].ToString() + " Kč";
                    label4.Text = penize[pocetSpravnych].ToString() + " Kč";
                    label5.Text = penize[pocetSpravnych + 1].ToString() + " Kč";
                }
                else if (posun == 3)
                {
                    label3.BackColor = Color.DarkGreen;
                    label4.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 4)
                {
                    label4.BackColor = Color.DarkGreen;
                    label5.BackColor = Color.DarkOrange;
                }




                if (obtiznost == 0 && pocetSpravnych > 5)
                {
                    obtiznost = 1;
                    InicializujPouzite();
                }
                else if (obtiznost == 1 && pocetSpravnych > 10)
                {
                    obtiznost = 2;
                    InicializujPouzite();
                }
                else if (obtiznost == 2 && pocetSpravnych > 15)
                {
                    label5.BackColor = Color.DarkGreen;
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

        int spravnaAktualni()
        {
            if (obtiznost == 0)
                return spravnaLehke[aktualniOtazka];
            else if (obtiznost == 1)
                return spravnaStredni[aktualniOtazka];
            else
                return spravnaTezke[aktualniOtazka];
        }

        void InicializujPouzite()
        {
            int pocet = 0;

            if (obtiznost == 0)
                pocet = otazkyLehke.Length;
            else if (obtiznost == 1)
                pocet = otazkyStredni.Length;
            else
                pocet = otazkyTezke.Length;

            pouzite = new bool[pocet];
        }
        int VyberNahodnouOtazku()
        {
            int pocet = pouzite.Length;
            int index;

            do
            {
                index = rnd.Next(pocet);
            } while (pouzite[index]);

            pouzite[index] = true;
            return index;
        }

        private void ukončitAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Opravdu chceš vypnout hru?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vysledek == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int spravna = spravnaAktualni();

            int[] spatne = new int[3];
            int index = 0;

            for (int i = 0; i < 4; i++)
            {
                if (i != spravna)
                {
                    spatne[index] = i;
                    index++;
                }
            }

            int nahodnaSpatna = spatne[rnd.Next(3)];

            for (int i = 0; i < 4; i++)
            {
                if (i != spravna && i != nahodnaSpatna)
                {
                    if (i == 0)
                    {
                        buttonA.Text = "A: nic";
                        buttonA.Enabled = false;
                    }
                    if (i == 1)
                    {
                        buttonB.Text = "B: nic";
                        buttonB.Enabled = false;
                    }
                    if (i == 2)
                    {
                        buttonC.Text = "C: nic";
                        buttonC.Enabled = false;
                    }
                    if (i == 3)
                    {
                        buttonD.Text = "D: nic";
                        buttonD.Enabled = false;
                    }
                }
            }
            button2.Enabled = false;
            pictureBox1.Visible = true;
        }
    }
}
