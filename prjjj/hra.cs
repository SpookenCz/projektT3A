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
        string[] otazkyLehke = { "Kolik je 2 + 2?", "Který sport nepoužívá míč", "Jaký je chemický symbol pro kyslík?", "Jaký strom má žaludy?", "Jaké je skupenství vody při 0 °C a níž?"};
        string[,] odpovediLehke =
        {
             {"3","4","5","6"}, {"Fotbal","Basketbal","Hokej","Volejbal"}, {"S","H","Hg","O"}, {"Dub","Buk","Borovice","Lípa"}, {"Plynné","Kapalné","Pevné","Žádné"},
        };
        int[] spravnaLehke = {1, 2, 3, 0, 2};

        string[] otazkyStredni = { "Kolik je 5 * 5?", "Kolik hráčů má jeden fotbalový tým na hřišti?", "Kdo složil slavnou „9. symfonii“?", "Který oceán leží mezi Amerikou a Evropou?", "Jaká měna se používá v Japonsku?", };
        string[,] odpovediStredni =
        {
            {"10","20","25","30"}, {"9","10","11","12"}, {"Mozart","Beethoven","Mach","Chopin"}, {"Severní ledový","Tichý","Indický","Atlantský"}, {"Jen","Won","Chuan","Dollar"},
        };
        int[] spravnaStredni = {2, 2, 1, 3, 0};

        string[] otazkyTezke = { "Kolik je 12 * 12?" };
        string[,] odpovediTezke =
        {
            {"100","144","120","130"},
        };
        int[] spravnaTezke = {1,};

        int aktualniOtazka = 0;
        int obtiznost = 0; // 0 = lehká, 1 = střední, 2 = těžká
        int pocetSpravnych = 0;
        int[] penize = { 1000, 2000, 3000, 5000, 10000, 20000, 50000, 100000 };
        bool[] pouzite;
        Random rnd = new Random();



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
        }

        void NactiOtazku()
        {
            aktualniOtazka = VyberNahodnouOtazku();

            if (obtiznost == 0)
            {
                labelOtazka.Text = otazkyLehke[aktualniOtazka];
                buttonA.Text = odpovediLehke[aktualniOtazka, 0];
                buttonB.Text = odpovediLehke[aktualniOtazka, 1];
                buttonC.Text = odpovediLehke[aktualniOtazka, 2];
                buttonD.Text = odpovediLehke[aktualniOtazka, 3];
            }
            else if (obtiznost == 1)
            {
                labelOtazka.Text = otazkyStredni[aktualniOtazka];
                buttonA.Text = odpovediStredni[aktualniOtazka, 0];
                buttonB.Text = odpovediStredni[aktualniOtazka, 1];
                buttonC.Text = odpovediStredni[aktualniOtazka, 2];
                buttonD.Text = odpovediStredni[aktualniOtazka, 3];
            }
            else
            {
                labelOtazka.Text = otazkyTezke[aktualniOtazka];
                buttonA.Text = odpovediTezke[aktualniOtazka, 0];
                buttonB.Text = odpovediTezke[aktualniOtazka, 1];
                buttonC.Text = odpovediTezke[aktualniOtazka, 2];
                buttonD.Text = odpovediTezke[aktualniOtazka, 3];
            }
        }

        void ZkontrolujOdpoved(int index)
        {
            if (index == spravnaAktualni())
            {
                MessageBox.Show("Správně!");
                pocetSpravnych++;

                if (obtiznost == 0 && pocetSpravnych >= 5)
                {
                    obtiznost = 1;
                    InicializujPouzite();
                }
                else if (obtiznost == 1 && pocetSpravnych >= 10)
                {
                    obtiznost = 2;
                    InicializujPouzite();
                }
                else if (obtiznost == 2 && pocetSpravnych >= 15)
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
    }
}
